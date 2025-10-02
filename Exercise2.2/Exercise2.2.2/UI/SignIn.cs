using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Monopoly.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class SignIn : Form
    {
        private AuthService _authService;
        public SignIn()
        {
            InitializeComponent();
            _authService = new AuthService();
        }
        public SignIn(AuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        public SignIn(string username)
        {
            InitializeComponent();
            txtUserName.Text = username;
            _authService = new AuthService();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            var input = txtUserName.Text.Trim();
            var password = txtPassword.Text.Trim();

            string message = null;

            if (string.IsNullOrEmpty(input) && string.IsNullOrEmpty(password))
            {
                message = "Vui lòng nhập tên người dùng và mật khẩu.";
            }
            else if (string.IsNullOrEmpty(input))
            {
                message = "Vui lòng nhập tên người dùng.";
            }
            else if (string.IsNullOrEmpty(password))
            {
                message = "Vui lòng nhập mật khẩu của bạn.";
            }

            if (!string.IsNullOrEmpty(message))
            {
                MessageBox.Show(message, "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_authService.SignIn(input, password))
            {
                MessageBox.Show("Đăng nhập thành công");

                Home home = new Home();
                home.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên người dùng và mật khẩu không chính xác. Vui lòng thử lại.");
            }

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
