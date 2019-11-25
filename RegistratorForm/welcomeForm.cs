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
    public partial class welcomeForm : Form
    {
        public string userName;
        public welcomeForm()
        {
            InitializeComponent();
        }

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text += " " + userName;
            if (userName == "Admin")
            {
                foreach(User user in Database.users)
                {
                    listView1.Items.Add(user.Name + " " + user.Surname + " " + user.Email);
                    listView1.Visible = true;
                }
            }
        }
    }
}
