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
using clothMarket;
namespace Card_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Phone[] phones = DataBase.GetDatas();
            Pagination pg = new Pagination(this);
            pg.cards_panel = grpBox;
            pg.createElementsButtons(phones,0,8, grpBox);
            int arrayLength = phones.Length;
            int paginationCount = pg.paginationCount(arrayLength);
            pg.createPagination(paginationGroupBox,grpBox , paginationCount, arrayLength);
            
        }

        private void btn_basket_Click(object sender, EventArgs e)
        {
            MyBasketForm basketForm = new MyBasketForm();
            basketForm.Show();
        }
    }
}
