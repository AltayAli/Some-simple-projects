using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary myLibrary = new MyLibrary();
            myLibrary.myArray = new int[6, 6];
            Random rd = new Random();
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    myLibrary.myArray[i, j] = rd.Next(0,9);
                    Console.Write(myLibrary.myArray[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] arr = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                   arr[i, j] = rd.Next(0, 9);
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(myLibrary.isLocatedIn(arr));
            Console.ReadLine();
        }
    }
}
