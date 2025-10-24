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
    public partial class TCPServerForm : Form
    {
        public TCPServerForm()
        {
            InitializeComponent();
        }

        private void btnOpenConnect_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnOpenConnect.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnOpenConnect_MouseDown(object sender, MouseEventArgs e)
        {
            btnOpenConnect.Top -= 1;
            btnOpenConnect.Left -= 1;
        }

        private void btnOpenConnect_MouseUp(object sender, MouseEventArgs e)
        {
            btnOpenConnect.Top += 1;
            btnOpenConnect.Left += 1;

        }

        private void btnCloseConnect_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnCloseConnect.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnCloseConnect_MouseDown(object sender, MouseEventArgs e)
        {
            btnCloseConnect.Top -= 1;
            btnCloseConnect.Left -= 1;
        }

        private void btnCloseConnect_MouseUp(object sender, MouseEventArgs e)
        {
            btnCloseConnect.Top += 1;
            btnCloseConnect.Left += 1;
        }

        private void btnViewDetails_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, btnViewDetails.ClientRectangle,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset,
            SystemColors.ControlLight, 5, ButtonBorderStyle.Outset);
        }

        private void btnViewDetails_MouseDown(object sender, MouseEventArgs e)
        {
            btnViewDetails.Top -= 1;
            btnViewDetails.Left -= 1;
        }

        private void btnViewDetails_MouseUp(object sender, MouseEventArgs e)
        {
            btnViewDetails.Top += 1;
            btnViewDetails.Left += 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
