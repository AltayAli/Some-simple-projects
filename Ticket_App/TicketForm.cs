using System;
using System.Collections;
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
    public partial class TicketForm : Form
    {
        public TicketForm()
        {
            InitializeComponent();
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            TicketsList.ticketFrm = this;
            ArrayList array = TicketsList.GetTickets();

            createCoplainment conplainment = new createCoplainment();
            conplainment.addToPage(array);
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            MyTicket tc = new MyTicket();
            tc.btn_send.Visible = true;
            tc.btn_edit.Visible = false;
            tc.Show();
        }
    }
}
