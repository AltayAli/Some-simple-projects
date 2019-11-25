using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_App
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void regusterButton_Click(object sender, EventArgs e)
        {
            User myUser = new User() {
                Name = txbx_name.Text,
                Surname = txbx_surname.Text,
                Email = txbx_email.Text,
                Password = txbx_password.Text
            };
            if (!DataBase.HasUser(myUser))
            {
                DataBase.Add(myUser);
                LoginForm lg = new LoginForm();
                lg.ShowDialog();
            }
        }
    }
}
