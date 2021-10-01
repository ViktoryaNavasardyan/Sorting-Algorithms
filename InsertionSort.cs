using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortClasses.Models
{
    class InsertionSort
    {
        static public long memory;

        public static double[] Sort(double[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                double value = array[i];
                bool flag = false;
                for (int j = i - 1; j >= 0 && !flag;)
                {
                    if (value < array[j])
                    {
                        array[j + 1] = array[j];
                        j--;
                        array[j + 1] = value;
                    }
                    else flag = true;
                }
            }
            return array;
        }
    }
}
