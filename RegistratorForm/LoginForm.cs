using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistratorForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = txbx_email.Text;
            string password = txbx_password.Text;
            if (Database.HasUser(login, password))
            {
                welcomeForm frm = new welcomeForm();

                frm.userName = Database.GetUserName(login);
                frm.Show();
            }
        }
    }
}
