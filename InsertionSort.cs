using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortClasses.Models
{
    class InsertionSort
    {
        public static double[] Sort(double[] arr)
        {
            long memory1 = GC.GetTotalMemory(false);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            //copy array
            double[] array = new double[arr.Length];
            for (int i = 0; i<arr.Length; i++)
            {
                array[i] = arr[i];
            }
            

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
            watch.Stop();
            Console.WriteLine($"Running time: {watch.ElapsedMilliseconds} ms");

            long memory2 = GC.GetTotalMemory(false);
            long memory = memory2 - memory1;
            Console.WriteLine("Memory usage:{0}", memory);
            return array;
        }
    }
}
