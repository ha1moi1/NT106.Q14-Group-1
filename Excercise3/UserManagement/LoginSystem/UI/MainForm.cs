using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSystem.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void grBoxUserInfo_Enter(object sender, EventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnChangePassword.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnChangePassword_MouseDown(object sender, MouseEventArgs e)
        {
            btnChangePassword.Top -= 1;
            btnChangePassword.Left -= 1;
        }

        private void btnChangePassword_MouseUp(object sender, MouseEventArgs e)
        {
            btnChangePassword.Top += 1;
            btnChangePassword.Left += 1;
        }

        private void btnSignOut_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnSignOut.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnSignOut_MouseDown(object sender, MouseEventArgs e)
        {
            btnSignOut.Top -= 1;
            btnSignOut.Left -= 1;
        }

        private void btnSignOut_MouseUp(object sender, MouseEventArgs e)
        {
            btnSignOut.Top += 1;
            btnSignOut.Left += 1;
        }

        private void btnExit_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnExit.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnExit_MouseDown(object sender, MouseEventArgs e)
        {
            btnExit.Top -= 1;
            btnExit.Left -= 1;
        }

        private void btnExit_MouseUp(object sender, MouseEventArgs e)
        {
            btnExit.Top += 1;
            btnExit.Left += 1;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            SignOutForm signOutForm = new SignOutForm();
            signOutForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
