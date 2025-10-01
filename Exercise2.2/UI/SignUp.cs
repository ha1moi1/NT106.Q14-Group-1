using Monopoly.BLL;
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
    public partial class SignUp : Form
    {
        private AuthService _authService;
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            string errorMessage;
            if (!_authService.ValidateSignUp(username, password, confirmPassword, email, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_authService.SignUp(username, password, email))
            {
                MessageBox.Show("Đăng ký thành công!");
                SignIn signIn = new SignIn(username);
                signIn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên người dùng đã tồn tại.");
            }
        }

        private void llblDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
