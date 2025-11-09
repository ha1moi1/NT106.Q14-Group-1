using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace Client.BLL
{
    public class TcpSocketClient
    {
        private TcpClient? _client;
        private NetworkStream? _ns;
        public record ServerResponse(bool ok);

        public async Task<bool> ConnectAsync(string ip = "127.0.0.1", int port = 9876)
        {
            try
            {
                _client = new TcpClient();
                await _client.ConnectAsync(ip, port);
                _ns = _client.GetStream();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Lỗi khi kết nối: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> SignInAsync(string user, string pass)
        {
            var req = new
            {
                action = "signin",
                user,
                pass
            };
            return await SendAndReceiveAsync(req);
        }

        public async Task<bool> SignUpAsync(string user, string pass, string email, string name, DateTime birthday)
        {

            var req = new
            {
                action = "signup",
                user,
                pass,
                email,
                name,
                birthday = birthday.ToString("yyyy-MM-dd")
            };
            return await SendAndReceiveAsync(req);
        }

        public void Close()
        {
            try { _ns?.Close(); } catch { }
            try { _client?.Close(); } catch { }
        }

        public void Dispose() => Close();

        // --------------------- PRIVATE -----------------------

        private async Task<bool> SendAndReceiveAsync(object payload)
        {
            if (_ns == null)
                throw new InvalidOperationException("Not connected to server.");

            // Serialize object -> JSON
            var json = JsonSerializer.Serialize(payload) + "<EOF>";
            var bytes = Encoding.UTF8.GetBytes(json);

            await _ns.WriteAsync(bytes, 0, bytes.Length);
            await _ns.FlushAsync();

            // Đọc phản hồi từ server
            var respJson = await ReadUntilEofAsync(_ns);
            var resp = JsonSerializer.Deserialize<ServerResponse>(respJson);

            return (resp?.ok ?? false);
        }

        public record UserInfoResponse(string? username, string? fullname, string? email, DateTime? birthday);

        public async Task<UserInfoResponse?> GetUserInfoAsync(string user)
        {
            if (_ns == null)
                throw new InvalidOperationException("⚠️ Chưa kết nối tới server!");

            var req = new
            {
                action = "getinfor",
                user
            };

            var json = JsonSerializer.Serialize(req) + "<EOF>";
            var bytes = Encoding.UTF8.GetBytes(json);

            await _ns.WriteAsync(bytes, 0, bytes.Length);
            await _ns.FlushAsync();

            string respJson = await ReadUntilEofAsync(_ns);

            try
            {
                var resp = JsonSerializer.Deserialize<UserInfoResponse>(respJson);
                return resp;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Lỗi đọc phản hồi GetUserInfo: {ex.Message}");
                return null;
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
}