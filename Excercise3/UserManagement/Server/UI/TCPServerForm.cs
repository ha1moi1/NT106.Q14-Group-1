using Server.BLL;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Server.DAL;
using Server.UI;

namespace Server
{
    public partial class TCPServerForm : Form
    {
        private TcpSocketServer? _server;
        private CancellationTokenSource? _cts;
        private Task? _serverTask;
        private int _connCount = 0;

        public TCPServerForm()
        {
            InitializeComponent();

            Load += TCPServerForm_Load;
        }

        private void TCPServerForm_Load(object? sender, EventArgs e)
        {

            txtBoxIP.Text = "0.0.0.0";
            txtBoxPort.Text = "0";
            txtBoxStatus.Text = "Không kết nối";
            txtBoxConnects.Text = "0";
            btnCloseConnect.Enabled = false;
        }

        private void btnOpenConnect_Click(object sender, EventArgs e)
        {
            if (txtBoxIP.Text != "127.0.0.1")
                txtBoxIP.Text = GetLocalIPv4();
            else
                txtBoxIP.Text = "127.0.0.1";

            txtBoxPort.Text = "9876";


            if (_server != null)
            {
                MessageBox.Show("Server đang chạy rồi!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(txtBoxPort.Text, out int port))
                port = 9876;

            try
            {
                _cts = new CancellationTokenSource();
                _server = new TcpSocketServer(port);


                _server.ClientConnected += OnClientConnected;
                _server.ClientDisconnected += OnClientDisconnected;

                txtBoxStatus.Text = "Đang lắng nghe...";
                btnOpenConnect.Enabled = false;
                btnCloseConnect.Enabled = true;

                _serverTask = Task.Run(async () =>
                {
                    try
                    {
                        await _server!.StartAsync();
                        AppendLog("Server đã dừng lắng nghe.");
                    }
                    catch (Exception ex)
                    {
                        AppendLog($"⚠️ Lỗi server: {ex.Message}");
                    }
                });

                AppendLog($"✅ Server khởi động thành công trên port {port}");
            }
            catch (Exception ex)
            {
                _server = null;
                _cts = null;

                txtBoxStatus.Text = "Không kết nối";
                btnOpenConnect.Enabled = true;
                btnCloseConnect.Enabled = false;

                MessageBox.Show($"Không thể khởi động server: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnCloseConnect_Click(object sender, EventArgs e)
        {
            if (_server == null)
            {
                AppendLog("⚠️ Server chưa được khởi động!");
                return;
            }

            btnCloseConnect.Enabled = false;

            try
            {
                _server.Stop();
                _cts?.Cancel();

                if (_serverTask != null)
                    await _serverTask;

                AppendLog("⏹ Server đã dừng.");
            }
            catch (Exception ex)
            {
                AppendLog($"⚠️ Lỗi khi dừng server: {ex.Message}");
            }
            finally
            {
                _server = null;
                _serverTask = null;

                _cts?.Dispose();
                _cts = null;

                txtBoxStatus.Text = "Không kết nối";
                _connCount = 0;
                txtBoxConnects.Text = "0";

                btnOpenConnect.Enabled = true;
                btnCloseConnect.Enabled = false;
            }
        }


        private void OnClientConnected()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(OnClientConnected));
                return;
            }

            _connCount++;
            txtBoxConnects.Text = _connCount.ToString();
            AppendLog($"🟢 Client mới kết nối.");
        }

        private void OnClientDisconnected()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(OnClientDisconnected));
                return;
            }

            _connCount = Math.Max(0, _connCount - 1);
            txtBoxConnects.Text = _connCount.ToString();
            AppendLog($"🔴 Client ngắt kết nối.");
        }

        // ====================== TIỆN ÍCH ======================
        private static string? GetLocalIPv4()
        {
            var list = NetworkInterface.GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up &&
                            (n.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                             n.NetworkInterfaceType == NetworkInterfaceType.Ethernet))
                .OrderBy(n => n.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ? 0 : 1)
                .SelectMany(n => n.GetIPProperties().UnicastAddresses)
                .Select(a => a.Address)
                .Where(a => a.AddressFamily == AddressFamily.InterNetwork &&
                            !a.ToString().StartsWith("169.254.") &&
                            !IPAddress.IsLoopback(a))
                .Select(a => a.ToString());

            return list.FirstOrDefault();
        }

        private void AppendLog(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(AppendLog), text);
                return;
            }

            lstBoxDiaryLog.Items.Add($"{DateTime.Now:HH:mm:ss}  {text}");
            lstBoxDiaryLog.TopIndex = lstBoxDiaryLog.Items.Count - 1;
        }

        // Cleanup khi đóng form
        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            if (_server != null)
            {
                AppendLog("Đang dừng server trước khi thoát...");
                _server.Stop();
                _cts?.Cancel();
                if (_serverTask != null)
                    await _serverTask;
            }

            base.OnFormClosing(e);
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            ClientManagementForm frm = new ClientManagementForm();
            frm.Show();
        }

        private void lblInfor_Click(object sender, EventArgs e)
        {
            ClientManagementForm frm = new ClientManagementForm();
            frm.Show();
        }
    }
}