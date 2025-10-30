using Client.BLL;
using Client.UI;
using System.Configuration;

namespace Client
{
    public partial class SignInForm : Form
    {
        private readonly AuthServiceCL _auth = new();
        private string _ip;
        private int _port;

        public SignInForm()
        {
            InitializeComponent();


            // Đọc ip và port từ App.config
            _ip = ConfigurationManager.AppSettings["ServerIP"] ?? "127.0.0.1";
            string portStr = ConfigurationManager.AppSettings["ServerPort"] ?? "9876";
            _port = int.TryParse(portStr, out var p) ? p : 9876;

            this.Load += SignInForm_Load;
        }


        private async void SignInForm_Load(object sender, EventArgs e)
        {
            bool connected = await _auth.ConnectAsync(_ip, _port);

            if (!connected)
            {
                MessageBox.Show("Không thể kết nối đến Server!", "Lỗi kết nối",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;


            bool ok = await _auth.SignIn(username, password);

            if (ok)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                var mainForm = new MainForm();
                mainForm.Show();
            }

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            var form = new SignUpForm(_auth);
            form.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}