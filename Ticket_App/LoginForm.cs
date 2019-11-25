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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email = txbx_email.Text;
            string password = txbx_password.Text;
            int userIndex = DataBase.HasUser(email,password);
            if (userIndex!=-1&&email!=""&&password!="")
            {
                User user = DataBase.GetStecificUser(email);
                TicketsList.activeUser = user;
                TicketForm ticket = new TicketForm();
                ticket.Show();
            }
        }
    }
}
