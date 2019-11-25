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
    public partial class MyTicket : Form
    {
        
        public MyTicket()
        {
            InitializeComponent();
        }

        private void grbx_Enter(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            ArrayList array = TicketsList.GetTickets();
            TicketsList.Add(setTicket());


            addTicketsToPage(array);


        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            ArrayList array = TicketsList.GetTickets();
            int index = TicketsList.getSpecificTicket(TicketsList.chancedTicketID);
            TicketsList.Update(index, setTicket());


            addTicketsToPage(array);
            this.Close();
        }

         Ticket setTicket()
        {
            User activeUser = TicketsList.activeUser;
            string shortDesc = txbx_short.Text;
            string detail = txbx_detail.Text;
            Ticket newTickew = new Ticket()
            {
                Name = activeUser.Name,
                Email = activeUser.Email,
                ShortDescription = shortDesc,
                Detail = detail
            };
            return newTickew;
        }
        void addTicketsToPage(ArrayList array)
        {
            if (array.Count % 5 == 0)
            {
                Pagination pg = new Pagination();
                int paginationCount = pg.paginationCount(array.Count);
                pg.createPagination(TicketsList.ticketFrm.grbx_pagination, TicketsList.ticketFrm.ticketViewer, paginationCount, array.Count);

            }
            createCoplainment conplainment = new createCoplainment();
            conplainment.addToPage(array);
        }
    }
}
