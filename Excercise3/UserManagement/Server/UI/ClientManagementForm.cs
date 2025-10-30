using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Server.UI
{
    public partial class ClientManagementForm : Form
    {
        public ClientManagementForm()
        {
            InitializeComponent();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public void AddClient(string username, string ip, int token)
        {
            dataGridView1.Rows.Add(username, ip, token);
        }

        public void RemoveClient(string username)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                if (row.Cells[0].Value?.ToString() == username)
                {
                    dataGridView1.Rows.Remove(row);
                    break;
                }
            }
        }


    }
}
