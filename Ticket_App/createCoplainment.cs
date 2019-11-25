using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_App.myControls;

namespace Ticket_App
{
    class createCoplainment
    {
        public static int y { get; set; }
        static createCoplainment()
        {
            y = 0;
        }
        public TicketControl AddTicket(Ticket ticket)
        {
            TicketControl ticketControl = new TicketControl();
            ticketControl.lbl_name.Text = ticket.Name;
            ticketControl.lbl_short.Text = ticket.ShortDescription;
            ticketControl.lblDetail.Text = ticket.Detail;
            ticketControl.lblStatus.Text = ticket.Status;

            ticketControl.btn_edit.Click += (a, b) =>
            {
                MyTicket tc = new MyTicket();
                tc.btn_edit.Visible = true;
                tc.btn_send.Visible = false;
                TicketsList.chancedTicketID = ticket.ID;
                tc.Show();
            };
            ticketControl.Location = new Point(0, y);
            y += 60;
            return ticketControl;
        }

        public void addToPage(ArrayList array)
        {

            createCoplainment cC = new createCoplainment();
            TicketsList.ticketFrm.ticketViewer.Controls.Clear();
            createCoplainment.y = 0;
            for (int i = array.Count - 1; i >= 0; i--)
            {
                var tck = cC.AddTicket((Ticket)array[i]);
                TicketsList.ticketFrm.ticketViewer.Controls.Add(tck);

            }
        }
        
    }
}
