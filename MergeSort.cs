using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortClasses.Models
{
    class MergeSort
    {
        static public long memory;
        public static double[] Sort(double[] array)
        {
            long memory1 = GC.GetTotalMemory(false);

            double[] left;
            double[] right;
            double[] result = new double[array.Length];
            if (array.Length <= 1)
                return array; 
            int midPoint = array.Length / 2;
            left = new double[midPoint];

            if (array.Length % 2 == 0)
                right = new double[midPoint];
            else
                right = new double[midPoint + 1];
            //populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //populate right array   
            int x = 0;
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            left = Sort(left);
            //Recursively sort the right array
            right = Sort(right);
            //Merge our two sorted arrays
            result = merge(left, right);
            long memory2 = GC.GetTotalMemory(false);
            MergeSort.memory += memory2 - memory1;
            return result;
        }

        //This method will be responsible for combining our two sorted arrays into one giant array
        public static double[] merge(double[] left, double[] right)
        {
            int resultLength = right.Length + left.Length;
            double[] result = new double[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}
