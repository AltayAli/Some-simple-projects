using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ms = new int[] { 5,23,12,4,9,63,6,8,10};
           for(int i = 0; i < ms.Length; i++)
            {
                int key = ms[i];
                int j = i - 1;
                while (j > 0 && ms[j] > key)
                {
                    ms[j + 1] = ms[j];
                    j--;
                }
                ms[j+1] = key;
            }
            foreach(int a in ms)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
