using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employe_App
{
    public partial class Form1 : Form
    {
        DataBase<Employee> company;
        DataBase<string> logs;
        public Form1()
        {
            InitializeComponent();
            company = new CompanyFile();
            logs = new logFile();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            Employee employe = new Employee
            {
                Name = txt_name.Text,
                Surname = txt_surname.Text,
                Birthday = dt_birthday.Value,
                Identification = txt_sv.Text,
                Reg_area = txt_qeydiyyat.Text,
                Workbook = txt_workBook.Text,
                CompanyName=cb_company.Text
            };
                company.Write(employe);
                string time = DateTime.Now.ToLongTimeString();
                string log = $"{time} -> {employe.Surname} {employe.Name} AZE:({employe.Identification}) sisteme elave olundu.";
                logs.Write(log);
            
        }

        private void btn_show_employe_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (string item in company.Read()) 
            {
                richTextBox1.Text += item + "\n";
            }
        }

        private void btn_show_logs_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            foreach (var item in logs.Read())
            {
                richTextBox2.Text += item+"\n";
            }
        }
    }
}
