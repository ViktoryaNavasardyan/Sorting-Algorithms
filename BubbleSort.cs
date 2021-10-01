using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortClasses.Models
{
    class BubbleSort
    {
        public static double[] Sort(double[] array)
        {
            int num = array.Length;
            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        // swap temprory and arr[i]
                        double tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
            }
            return array;
        }
    }
}
