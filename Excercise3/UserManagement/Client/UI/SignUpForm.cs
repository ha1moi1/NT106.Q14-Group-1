using Client.Models;
using System;
using System.Windows.Forms;
using Client.BLL;
using System.Configuration;

namespace Client.UI
{
    public partial class SignUpForm : Form
    {
        private readonly AuthServiceCL _auth;

        public SignUpForm(AuthServiceCL auth)
        {
            InitializeComponent();
            _auth = auth;

        }

        private async void btnOK_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string email = txtBoxEmail.Text.Trim();
            string? name = string.IsNullOrWhiteSpace(txtBoxFullName.Text) ? null : txtBoxFullName.Text.Trim();

            DateTime? birthday = BirthdayUser.CustomFormat == " " ? null : BirthdayUser.Value;

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thiếu dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = await _auth.SignUp(username, password, email, name, birthday);
            if (ok)
            {
                MessageBox.Show("🎉 Đăng ký thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                SignInForm form = new SignInForm();
                form.Show();
                this.Hide();
            }

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignInForm form = new SignInForm();
            form.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            BirthdayUser.CustomFormat = " ";
        }
    }
}