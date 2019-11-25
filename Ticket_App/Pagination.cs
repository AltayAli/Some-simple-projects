using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticket_App
{
    class Pagination
    {
        int totalElementInPage = 5;
        public ArrayList ticketArray;
        public static int pagination;
        static Pagination()
        {
            pagination = 0;
        }
        public Pagination()
        {
            pagination++;
        }
        public int paginationCount(float num)
        {
            float f = (num / totalElementInPage);
            return (int)Math.Ceiling(f);
        }
        public void createPagination(GroupBox paginationLocatedBox, ListView Listview,int pagCount, int limit)
        {
            int xFPagination = 5;
            for (int i = 0; i < pagCount; i++)
            {
                Button button = createButton((i + 1).ToString(), new Size(20, 20), new Point(xFPagination, 10));

                
                button.Click += (a, b) =>
                {
                    Listview.Controls.Clear();
                    int elementStartIndex = int.Parse(button.Text)-1;
                    int start = totalElementInPage*(pagination - elementStartIndex);
                    int elemntCountForLastPaginationNumber = limit - start;
                   
                        createTicket(ticketArray,start, 0);
                };
                xFPagination += 25;
                paginationLocatedBox.Controls.Add(button);
            }
        }
        public void createTicket(ArrayList tickets, int start, int paginationSize)
        {
            tickets = TicketsList.GetTickets();
            if (tickets.Count > 0)
            {
                createCoplainment cC = new createCoplainment();
                createCoplainment.y = 0;
                for (int i = start-1; i >=paginationSize; i--)
                {
                    var tck = cC.AddTicket((Ticket)tickets[i]);
                    TicketsList.ticketFrm.ticketViewer.Controls.Add(tck);


                }

            }
        }

        public Button createButton(string txt, Size size, Point point)
        {
            Button button = new Button();
            button.Text = txt;
            button.Size = size;
            button.Location = point;
            return button;
            
        }
    }
}
