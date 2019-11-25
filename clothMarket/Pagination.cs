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
        public cloth[] clothesArray;
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
                Button button = createButton((i + 1).ToString(), new Size(20, 20), new Point(xFPagination, 20));
                button.Click += (a, b) =>
                {
                    secondaryGroupBox.Controls.Clear();
                    int elementStarIndex = int.Parse(button.Text);
                    int elemntCountForLastPaginationNumber = limit - totalElementInPage * (elementStarIndex - 1);
                    if (elemntCountForLastPaginationNumber < totalElementInPage)
                    {
                        createElementsButtons(clothesArray,totalElementInPage * (elementStarIndex - 1), elemntCountForLastPaginationNumber,secondaryGroupBox);
                    }
                    else
                        createElementsButtons(clothesArray,totalElementInPage * (elementStarIndex - 1), totalElementInPage,secondaryGroupBox);
                };
                xFPagination += 25;
                paginationLocatedBox.Controls.Add(button);
            }
        }
        public void createElementsButtons(cloth[] clothes,int start, int paginationSize,GroupBox groupBox)
        {
            int xFPagination = 30;
            int yFPagination = 30;
            for (int i = start; i < start + paginationSize; i++)
            {
                if (i % 4 == 0 && i != start)
                {
                    xFPagination = 30;
                    yFPagination += 100;
                }
                string text = clothes[i].name + "\n" + clothes[i].size + "\n" + clothes[i].price + "\n" + clothes[i].color;
                Button button = createButton(text, new Size(110, 90), new Point(xFPagination, yFPagination));
                xFPagination += 120;

                groupBox.Controls.Add(button);
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
