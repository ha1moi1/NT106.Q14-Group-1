
using Client.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Client.BLL
{
    public class AuthServiceCL
    {
        private readonly TcpSocketClient _client = new();

        public async Task<bool> ConnectAsync(string ip = "127.0.0.1", int port = 9876)
        {
            try
            {
                return await _client.ConnectAsync(ip, port);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối đến server: {ex.Message}",
                    "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> SignIn(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string hashedPassword = Sha256Hex(password);

            try
            {
                bool ok = await _client.SignInAsync(username, hashedPassword);
                if (!ok)
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Đăng nhập thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return ok;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng nhập: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> SignUp(string username, string password, string email, string? name, DateTime? birthday)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để đăng ký!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
             string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng điền thông tin bắt buộc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (username.Length < 3)
            {
                MessageBox.Show("Tên người dùng phải có ít nhất 3 kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (password.Length < 3)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 3 kí tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string hashedPassword = Sha256Hex(password);

            try
            {
                bool ok = await _client.SignUpAsync(username, hashedPassword, email, name ?? "", birthday ?? DateTime.MinValue);
                if (!ok)
                {
                    MessageBox.Show("Tên người dùng hoặc email đã tồn tại!", "Đăng ký thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return ok;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng ký: {ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public async Task<User?> GetInforAfterSignIn(string username)
        {
            try
            {
                var info = await _client.GetUserInfoAsync(username);

                if (info == null)
                {
                    Console.WriteLine("⚠️ Không nhận được thông tin user từ server!");
                    return null;
                }

                return new User
                {
                    Username = info.username,
                    FullName = info.fullname,
                    Email = info.email,
                    BirthDay = info.birthday
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"❌ Lỗi khi lấy thông tin user: {ex.Message}");
                return null;
            }
        }

        public void Close() => _client.Close();


        private static string Sha256Hex(string input)
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder();
            foreach (var b in bytes)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
    }
}