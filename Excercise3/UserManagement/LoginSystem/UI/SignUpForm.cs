using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace LoginSystem.UI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            this.BirthdayUser.Format = DateTimePickerFormat.Custom;
            this.BirthdayUser.CustomFormat = " ";
        }

        private void btnOK_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnOK.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnOK_MouseDown(object sender, MouseEventArgs e)
        {
            btnOK.Top -= 1;
            btnOK.Left -= 1;
        }

        private void btnOK_MouseUp(object sender, MouseEventArgs e)
        {
            btnOK.Top += 1;
            btnOK.Left += 1;
        }

        private void btnCancel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnCancel.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            btnCancel.Top -= 1;
            btnCancel.Left -= 1;
        }

        private void btnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            btnCancel.Top += 1;
            btnCancel.Left += 1;
        }

        private void btnSignIn_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnSignIn.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnSignIn_MouseDown(object sender, MouseEventArgs e)
        {
            btnSignIn.Top -= 1;
            btnSignIn.Left -= 1;
        }

        private void btnSignIn_MouseUp(object sender, MouseEventArgs e)
        {
            btnSignIn.Top += 1;
            btnSignIn.Left += 1;
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

        private void txtBoxBirthday_TextChanged(object sender, EventArgs e)
        {

        }

        private void BirthdayUser_ValueChanged(object sender, EventArgs e)
        {

            this.BirthdayUser.Format = DateTimePickerFormat.Custom;
            this.BirthdayUser.CustomFormat = "dd-MM-yyyy";
        }

        private void BirthdayUser_EnabledChanged(object sender, EventArgs e)
        {

        }
        
    }
}
