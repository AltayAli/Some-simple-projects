using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peak_algoritm
{
    class Peak_algotirm
    {
        public int[] array;
        public Peak_algotirm(params int[] arr)
        {
            array = arr;
        }

        public int[] findPeaks()
        {
            ArrayList arr = new ArrayList();

            for(int i = 0; i < array.Length; i++)
            {
                if (i-1>=0&&i+1<array.Length)
                {
                        if (array[i] >= array[i + 1] && array[i] >= array[i - 1])
                        {
                            arr.Add(array[i]);
                        }
                }
                else if (i - 1 < 0 && i + 1 <= array.Length)
                {
                    if (array[i] >= array[i + 1] )
                    {
                        arr.Add(array[i]);
                    }
                }
                else if (i - 1 >= 0 && i + 1 > array.Length)
                {
                    if (array[i] >= array[i - 1])
                    {
                        arr.Add(array[i]);
                    }
                }
                else
                {
                    arr.Add(array[i]);
                }
            }

            return (int[])arr.ToArray(typeof(int));
        }
    }
}
