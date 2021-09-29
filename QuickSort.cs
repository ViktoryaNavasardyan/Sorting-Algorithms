using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortClasses.Models
{
    class QuickSort
    {
        static public void Sort(double[] arr, int left, int right)
        {
            long memory1 = GC.GetTotalMemory(false);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            // For Recusrion 
            if (left < right)
            {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                    Sort(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    Sort(arr, pivot + 1, right);
            }
            watch.Stop();
            Console.WriteLine($"Running time: {watch.ElapsedMilliseconds} ms");
            long memory2 = GC.GetTotalMemory(false);
            long memory = memory2 - memory1;
            Console.WriteLine("Memory usage:{0}", memory);
        }
        static int Partition(double[] numbers, int left, int right)
        {
            double pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;
                while (numbers[right] > pivot)
                    right--;
                if (left < right)
                {
                    double temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        
    }
}
