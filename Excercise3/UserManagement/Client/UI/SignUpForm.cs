using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            this.BirthdayUser.Format = DateTimePickerFormat.Custom;
            this.BirthdayUser.CustomFormat = " ";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SignInForm form = new SignInForm();
            form.ShowDialog();
        }

        private void BirthdayUser_ValueChanged(object sender, EventArgs e)
        {
            this.BirthdayUser.Format = DateTimePickerFormat.Custom;
            this.BirthdayUser.CustomFormat = "dd-MM-yyyy";
            this.BirthdayUser.CustomFormat = " ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
