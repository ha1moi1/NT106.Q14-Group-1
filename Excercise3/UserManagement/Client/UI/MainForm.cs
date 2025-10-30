using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Models;
namespace Client.UI
{
    public partial class MainForm : Form
    {
        private User _currentUser;

        public MainForm(User user)
        {
            InitializeComponent();
            _currentUser = user;

            lblDisplayUsername.Text = user.Username;
            lblDisplayFullName.Text = user.FullName;
            lblDisplayBirthday.Text = user.BirthDay.ToString();
            lblDisplayEmail.Text = user.Email;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            SignOutForm signOutForm = new SignOutForm();
            signOutForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
