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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAppName_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

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
            btnOK.Top += 1;
            btnOK.Left += 1;
        }

        private void btnOK_MouseUp(object sender, MouseEventArgs e)
        {
            btnOK.Top -= 1;
            btnOK.Left -= 1;
        }

        private void btnCancel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnCancel.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnCancel_MouseUp(object sender, MouseEventArgs e)
        {
            btnCancel.Top += 1;
            btnCancel.Left += 1;
        }

        private void btnCancel_MouseDown(object sender, MouseEventArgs e)
        {
            btnCancel.Top -= 1;
            btnCancel.Left -= 1;
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            SignUpForm form = new SignUpForm();
            form.ShowDialog();
        }

        private void btnRegister_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnRegister.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnRegister_MouseDown(object sender, MouseEventArgs e)
        {
            btnRegister.Top -= 1;
            btnRegister.Left -= 1;
        }

        private void btnRegister_MouseUp(object sender, MouseEventArgs e)
        {
            btnRegister.Top += 1;
            btnRegister.Left += 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.ShowDialog();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
