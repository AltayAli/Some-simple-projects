using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clothMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            Pagination pagination = new Pagination();
            pagination.clothesArray = DataBase.GetAllClothes();
            int arrayLength = pagination.clothesArray.Length;
            int paginationCount = pagination.paginationCount(arrayLength);
            pagination.createPagination(paginationGroupBox,Clothes, paginationCount, arrayLength);
            pagination.createElementsButtons(pagination.clothesArray, 0, 8, Clothes);
           
            
        }
       
    }
}
