using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_App
{
    class Ticket{
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ShortDescription { get; set; }
        public string Detail { get; set; }
        public string Status { get; set; }
    }
    static class TicketsList
    {
        public static User activeUser { get; set; }
        static readonly ArrayList Tickets;
        static int tcID;
        public static TicketForm ticketFrm;
        public static int chancedTicketID;
        static  TicketsList()
        {
            tcID = 0;
            Tickets = new ArrayList();
            ticketFrm = new TicketForm();
        }

       public  static void Add(Ticket ticket)
        {
            tcID++;
            ticket.ID=tcID;
            Tickets.Add(ticket);
        }
        public static void Update(int ID,Ticket ticket)
        {
            Tickets[ID] = ticket;;
        }

       public static ArrayList GetTickets()
        {
            return Tickets;
        }
        public static int getSpecificTicket(int ID)
        {
            int index = -1;
           for(int i =0;i<Tickets.Count;i++)
            {
                Ticket checkedTicket = (Ticket)Tickets[i];
                if (checkedTicket.ID== ID)
                {
                    index = i;
                }
            }
            return index;
        }
    }
}
