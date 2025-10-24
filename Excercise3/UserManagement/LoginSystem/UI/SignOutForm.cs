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
    public partial class SignOutForm : Form
    {
        public SignOutForm()
        {
            InitializeComponent();
        }

        private void btnYes_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnYes.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnYes_MouseUp(object sender, MouseEventArgs e)
        {
            btnYes.Top += 1;
            btnYes.Left += 1;
        }

        private void btnYes_MouseDown(object sender, MouseEventArgs e)
        {
            btnYes.Top -= 1;
            btnYes.Left -= 1;
        }

        private void btnNo_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnNo.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnNo_MouseDown(object sender, MouseEventArgs e)
        {
            btnNo.Top -= 1;
            btnNo.Left -= 1;
        }

        private void btnNo_MouseUp(object sender, MouseEventArgs e)
        {
            btnNo.Top += 1;
            btnNo.Left += 1;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
