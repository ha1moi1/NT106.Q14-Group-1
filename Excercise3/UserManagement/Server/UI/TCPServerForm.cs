using Server.UI;

namespace Server
{
    public partial class TCPServerForm : Form
    {
        public TCPServerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            ClientManagementForm frm = new ClientManagementForm();
            frm.Show();
        }
    }
}
