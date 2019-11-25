using Card_App.myControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Card_App
{
    public partial class MyBasketForm : Form
    {
        public MyBasketForm()
        {
            InitializeComponent();
        }

        private void MyBasketForm_Load(object sender, EventArgs e)
        {
            BasketItem[] bsktItems = Basket.basketItem;
            int y = 10;
            foreach(BasketItem basket in bsktItems)
            {
                if (basket != null)
                {
                    BasketİtemTemplate bs = new BasketİtemTemplate();
                    bs.lbl_name.Text = basket.phone.Name;
                    bs.lbl_price.Text = basket.count.ToString();
                    bs.lbl_total.Text = (basket.count * basket.phone.Price).ToString();
                    bs.btn_minus.Click += (a, b) =>
                    {
                        if (int.Parse(bs.lbl_price.Text)>1)
                        {
                            basket.count--;
                            bs.lbl_price.Text = basket.count.ToString();
                            bs.lbl_total.Text = (basket.count * basket.phone.Price).ToString();
                        }
                    };
                    bs.btn_plus.Click += (a, b) =>
                    {
                        basket.count++;
                        bs.lbl_price.Text = basket.count.ToString();
                        bs.lbl_total.Text = (basket.count * basket.phone.Price).ToString();

                    };
                    bs.Location = new Point(20, y);
                    y += 70;
                    this.Controls.Add(bs);
                }


            }
        }
    }
}
