using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkGenerator
{
    public partial class Form1 : Form
    {
        CheckGenerator cg = new CheckGenerator();
        public Form1()
        {
            InitializeComponent();
            generateCheck();
        }
        private void generateCheck()
        {
            foreach (Button item in groupBox_services.Controls)
            {
                item.Click += (a, b) =>
                {
                    Button btn = (Button)a;
                    string key = ConfigurationManager.AppSettings[btn.Text];
                    lbl_check.Text = cg.ApplyCheck(key);
                };
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (cg.GetCheck()!=null)
            {
                lbl_service.Text = cg.GetCheck();
            }
            else
            {
                lbl_service.Text = "Service is not exist!";
            }
        }
    }
}
