using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string username = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string password = textBox3.Text.Trim();
            string confirmPassword = textBox4.Text.Trim();

            // 1. Kiểm tra các trường có rỗng không
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!",
                               "Cảnh báo",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            // 2. Kiểm tra độ dài username (tối thiểu 3 ký tự)
            if (username.Length < 3)
            {
                MessageBox.Show("Tên người dùng phải có ít nhất 3 ký tự!",
                               "Cảnh báo",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            // 3. Kiểm tra email hợp lệ
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập đúng định dạng email.",
                               "Cảnh báo",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            // 4. Kiểm tra độ dài mật khẩu (tối thiểu 6 ký tự)
            if (password.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!",
                               "Cảnh báo",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                textBox3.Focus();
                return;
            }

            // 5. Kiểm tra 2 mật khẩu có khớp nhau không
            if (password != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!",
                               "Cảnh báo",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                textBox4.Clear();
                textBox4.Focus();
                return;
            }

            // 6. Kiểm tra username đã tồn tại trong database chưa
            Modify modify = new Modify();
            if (modify.CheckUsernameExists(username))
            {
                MessageBox.Show("Tên người dùng đã tồn tại!\nVui lòng chọn tên khác.",
                               "Lỗi",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
     

            // 8. LƯU TÀI KHOẢN VÀO DATABASE
            bool success = modify.RegisterAccount(username, email, password);

            if (success)
            {
                MessageBox.Show("🎉 Đăng ký thành công!\n",
                               "Thành công",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);

                // Xóa tất cả các ô nhập liệu
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                // Chuyển sang form đăng nhập (thay SignIn bằng tên form đăng nhập của bạn)
                SignIn signInForm = new SignIn();
                signInForm.Show();
                this.Hide(); // Ẩn form đăng ký
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại!\nVui lòng kiểm tra kết nối database và thử lại.",
                               "Lỗi",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            }
        }

        private void llblDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        
    }
}
