using Card_App;
using Card_App.myControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothMarket
{
    class Pagination
    {
        int totalElementInPage = 8;
        public Phone[] phoneArray;
        public Pagination(MainForm form)
        {
            this.mf = form;
        }

        MainForm mf ;
        public GroupBox cards_panel;
        public int paginationCount(float num)
        {
            float f = (num / totalElementInPage);
            return (int)Math.Ceiling(f);
        }
        public void createPagination(GroupBox paginationLocatedBox,GroupBox secondaryGroupBox,int pagCount,int limit)
        {
            int xFPagination = 5;
            for (int i = 0; i < pagCount; i++)
            {
                Button button = createButton((i + 1).ToString(), new Size(20, 20), new Point(xFPagination, 10));
                button.Click += (a, b) =>
                {
                    secondaryGroupBox.Controls.Clear();
                    int elementStarIndex = int.Parse(button.Text);
                    int elemntCountForLastPaginationNumber = limit - totalElementInPage * (elementStarIndex - 1);
                    if (elemntCountForLastPaginationNumber < totalElementInPage)
                    {
                        createElementsButtons(phoneArray,totalElementInPage * (elementStarIndex - 1), elemntCountForLastPaginationNumber,secondaryGroupBox);
                    }
                    else
                        createElementsButtons(phoneArray, totalElementInPage * (elementStarIndex - 1), totalElementInPage,secondaryGroupBox);
                };
                xFPagination += 25;
                paginationLocatedBox.Controls.Add(button);
            }
        }
        public void createElementsButtons(Phone[] phones,int start, int paginationSize,GroupBox groupBox)
        {
            int x = 5;
            int y = 5;
           
            phones = DataBase.GetDatas();
            for (int i = start; i < start+paginationSize; i++)
            {
                if (i % 4 == 0 && i != start)
                {
                    y += 250;
                    x = 5;
                }
                CardTemplate crd = new CardTemplate();
                crd.lbl_Name.Text = phones[i].Name;
                crd.lbl_Price.Text = phones[i].Price.ToString();
                crd.pictureBox1.ImageLocation ="C:/Users/ALTAY/Downloads/item-03.jpg";
                crd.Location = new Point(x, y);
                crd.btn_add.Name = i.ToString();
                crd.btn_add.Click += (a, b) =>
                {
                    Button btn = (Button)a;

                    BasketItem bi = new BasketItem();
                    bi.phone = phones[int.Parse(btn.Name)];
                    bi.count = 1;
                    Basket.Add(bi);
                    mf.btn_basket.Text = Basket.counter.ToString();
                };
                cards_panel.Controls.Add(crd);
                
                x += 200;
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
