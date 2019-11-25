using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employe_App
{
    abstract class DataBase<T>
    {
        protected List<T> list;
        public DataBase()
        {
            list = new List<T>();
        }
        public abstract void Write(T item);
        public abstract string[] Read();
    }
    class Company : DataBase<Employee>
    {

        public override void Write(Employee employee)
        {
            list.Add(employee);
        }
        public override string[] Read()
        {
            string[] txt = new string[list.Count];
            int count = 0;
            foreach (Employee item in list)
            {
                txt[count] = $"{item.CompanyName}\n{item.Name} {item.Surname}\nAZE:{item.Identification}" +
                    $"\n{item.Reg_area}\n{item.Workbook}\n{item.Birthday}\n";
                count++;
            }
            return txt;
        }
    }
    class CompanyFile : DataBase<Employee>
    {
        private string path = "Company.txt";
        public override string[] Read()
        {
            return File.ReadAllLines(path).ToArray();
        }

        public override void Write(Employee item)
        {
            string[] text = new string[1];
            text[0] = $"{item.CompanyName}\n{item.Name} {item.Surname}\nAZE:{item.Identification}" +
                   $"\n{item.Reg_area}\n{item.Workbook}\n{item.Birthday}\n";
            File.AppendAllLines(path, text);
        }
    }
    class Log : DataBase<string>
    {

        public override void Write(string log)
        {
            list.Add(log);
        }
        public override string[] Read()
        {
            return list.ToArray();
        }

    }
    class logFile : DataBase<string>
    {
        private string path = "Log.txt";
        public override void Write(string log)
        {
            string[] txt = new string[] { log };
            File.AppendAllLines(path, txt);
        }
        public override string[] Read()
        {
            return File.ReadAllLines(path);
        }

    }
}
