using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
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
        public SignIn()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 signUp = new Form1();
            signUp.Show();
            this.Hide();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            // Kiểm tra input rỗng
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!",
                               "Thông báo",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra đăng nhập
            Modify modify = new Modify();
            bool isValidLogin = modify.CheckLogin(username, password);

            if (isValidLogin)
            {
                MessageBox.Show("Đăng nhập thành công!",
                               "Thông báo",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);



                AfterSignUp mainForm = new AfterSignUp();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!",
                               "Đăng nhập thất bại",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

                // Xóa mật khẩu và focus lại textbox
                textBox2.Clear();
                textBox1.Focus();
            }
        }

       
    }
}
