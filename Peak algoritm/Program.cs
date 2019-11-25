using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Peak_algoritm
{
    class Program
    {
        static void Main(string[] args)
        {
            Peak_algotirm peak = new Peak_algotirm(14,13,35,24,25);
            int[] arr = peak.findPeaks();
            foreach(int i in arr)
            {
                WriteLine(i);

            }
            ReadLine();
        }
    }
}