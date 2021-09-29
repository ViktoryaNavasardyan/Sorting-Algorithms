using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortClasses.Models
{
    class BubbleSort
    {
        public static double[] Sort(double[] arr)
        {
            long memory1 = GC.GetTotalMemory(false);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            //copy array
            double[] array = arr;
            int num = array.Length;
            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        // swap tmp and arr[i]
                        double tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
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
