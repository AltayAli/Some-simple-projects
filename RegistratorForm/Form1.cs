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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void regusterButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = txbx_name.Text;
            user.Email = txbx_email.Text;
            user.Surname = txbx_surname.Text;
            user.Password = txbx_password.Text;
            if (!Database.HasUser(user))
            {
                Database.AddUser(user);
                LoginForm loginfrm = new LoginForm();
                loginfrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("This user already been","User error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void login_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginfrm = new LoginForm();
            loginfrm.ShowDialog();
        }
    }
}
