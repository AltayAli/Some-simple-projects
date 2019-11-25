using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_App
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Reg_area { get; set; }
        public string Identification { get; set; }
        public DateTime Birthday { get; set; }

    }
    class Employee : Person
    {
        public string CompanyName { get; set; }
        public string Workbook { get; set; }
    }
   

}
