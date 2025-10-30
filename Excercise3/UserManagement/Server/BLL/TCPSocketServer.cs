using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Server.BLL;

public class TcpSocketServer
{
    private readonly int _port;
    private TcpListener? _listener;
    private CancellationTokenSource? _cts;
    private int _token;
    public bool IsRunning { get; private set; } = false;

    private readonly AuthService _auth = new();

    public event Action<string>? ClientConnected;
    public event Action<string>? ClientDisconnected;
    public event Action<string, string, int>? UserLoggedIn;

    private readonly Dictionary<TcpClient, string> _clientIps = new();

    public TcpSocketServer(int port = 9876) => _port = port;

    public async Task StartAsync()
    {
        if (IsRunning)
        {
            Stop();
        }

        _cts = new CancellationTokenSource();
        _listener = new TcpListener(IPAddress.Any, _port);
        _listener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
        _listener.Start();


        Console.WriteLine($"Server đang lắng nghe trên port {_port}");

        while (!_cts.IsCancellationRequested)
        {
            try
            {
                var client = await _listener.AcceptTcpClientAsync(_cts.Token);

                if (client.Client.RemoteEndPoint is IPEndPoint remote)
                {
                    string ip = remote.Address.ToString();
                    int port = remote.Port;
                    _clientIps[client] = $"{ip}:{port}";

                    Console.WriteLine($"Client mới kết nối: {ip}:{port}");
                    ClientConnected?.Invoke(ip);
                }

                _ = Task.Run(async () =>
                {
                    try
                    {
                        await HandleClientAsync(client);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi client: {ex.Message}");
                    }
                    finally
                    {
                        try
                        {
                            string? ip = null;
                            if (_clientIps.TryGetValue(client, out string addr))
                            {
                                ip = addr.Split(':')[0];
                                _clientIps.Remove(client);
                            }

                            if (ip != null)
                            {
                                Console.WriteLine($"Client ngắt kết nối: {ip}");
                                ClientDisconnected?.Invoke(ip);
                            }

                            client?.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Lỗi khi đóng kết nối client: {ex.Message}");
                        }
                    }
                });
            }
            catch (OperationCanceledException)
            {
                break;
            }
        }
    }

    public void Stop()
    {
        try { _cts?.Cancel(); } catch { }
        try { _listener?.Stop(); } catch { }

        IsRunning = false;
        Console.WriteLine(" Server đã dừng.");
    }

    private async Task HandleClientAsync(TcpClient client)
    {
        var ns = client.GetStream();

        try
        {
            while (client.Connected)
            {
                string json = await ReadUntilEofAsync(ns);
                if (string.IsNullOrWhiteSpace(json))
                    break;

                ServerResponse resp;

                try
                {
                    using var doc = JsonDocument.Parse(json);
                    var root = doc.RootElement;
                    var action = root.GetProperty("action").GetString()?.ToLowerInvariant();

                    switch (action)
                    {
                        // Đăng nhập
                        case "signin":
                            {
                                var user = root.GetProperty("user").GetString() ?? "";
                                var pass = root.GetProperty("pass").GetString() ?? "";
                                bool ok = _auth.CheckInforSignIn(user, pass);


                                resp = ok ? ServerResponse.Ok : ServerResponse.Fail;

                                if (ok && client.Client.RemoteEndPoint is IPEndPoint remote)
                                {
                                    string ip = remote.Address.ToString();
                                    _token++;
                                    
                                    UserLoggedIn?.Invoke(user, ip, _token);
                                }
                                break;
                            }

                        case "signup":
                            {
                                var user = root.GetProperty("user").GetString() ?? "";
                                var pass = root.GetProperty("pass").GetString() ?? "";
                                var email = root.GetProperty("email").GetString() ?? "";
                                var name = root.GetProperty("name").GetString() ?? "";
                                var birthdayStr = root.GetProperty("birthday").GetString() ?? "";
                                DateTime birthday = DateTime.Parse(birthdayStr);
                                bool ok = _auth.Register(user, pass, email, name, birthday);
                                resp = ok ? ServerResponse.Ok : ServerResponse.Fail;
                                break;
                            }

                        case "getinfor":
                            {
                                var user = root.GetProperty("user").GetString() ?? "";
                                (string USERNAME, string FULLNAME, string EMAIL, DateTime? BIRTHDAY) = _auth.GetInforSignIn(user);

                                var userInfoResp = new UserInfoResponse(user, FULLNAME, EMAIL, BIRTHDAY);
                                var jsonResp = JsonSerializer.Serialize(userInfoResp);
                                var infoBytes = Encoding.UTF8.GetBytes(jsonResp + "<EOF>");
                                await ns.WriteAsync(infoBytes, 0, infoBytes.Length);
                                await ns.FlushAsync();
                                continue;
                            }

                        default:
                            resp = ServerResponse.Fail;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Lỗi xử lý JSON: {ex.Message}");
                    resp = ServerResponse.Fail;
                }

                // Gửi phản hồi
                var payload = JsonSerializer.Serialize(resp);
                var bytes = Encoding.UTF8.GetBytes(payload + "<EOF>");
                await ns.WriteAsync(bytes, 0, bytes.Length);
                await ns.FlushAsync();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"⚠️ Lỗi kết nối client: {ex.Message}");
        }
        finally
        {
            if (_clientIps.TryGetValue(client, out string addr))
                Console.WriteLine($"Client đóng kết nối: {addr}");
            else
                Console.WriteLine($"Client đóng kết nối (chưa có IP)");

            ns.Close();
            client.Close();
        }
    }

    private static async Task<string> ReadUntilEofAsync(NetworkStream ns)
    {
        var sb = new StringBuilder();
        var buf = new byte[4096];

        while (true)
        {
            int n = await ns.ReadAsync(buf, 0, buf.Length);
            if (n <= 0) break;

            sb.Append(Encoding.UTF8.GetString(buf, 0, n));
            var s = sb.ToString();
            int eof = s.IndexOf("<EOF>", StringComparison.Ordinal);
            if (eof >= 0)
                return s.Substring(0, eof);
        }

        return sb.ToString();
    }
}

public record ServerResponse(bool ok)
{
    public static ServerResponse Ok => new(true);
    public static ServerResponse Fail => new(false);
}

public record UserInfoResponse(string? username, string? fullname, string? email, DateTime? birthday);