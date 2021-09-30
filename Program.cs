using SortClasses.Models;
using System;
using System.Collections.Generic;


namespace SortClasses
{
    class Program
    {
        static List<long> AllMiliseconds = new List<long>();

        static void Main(string[] args)
        {
            bool endApp = false;
            while (!endApp)
            {
                Console.WriteLine("=============================================== ");
                string inputValue = default;
                int N = InputSomethingsCount(inputValue);
                double[] RandomArray = new double[N];
                Random rnd = new Random();
                //N Doubles between 0 and 100.
                for (int i = 0; i < N; i++)
                {
                    RandomArray[i] = rnd.NextDouble() * 100;
                }
                Console.WriteLine("------------------------------");
                Console.Write("Your array is:------------->");
                printIt(RandomArray);
                string operation = EnterMethod();
                OperationHandeling(operation, RandomArray);
                FindMinimal(AllMiliseconds);
                //ending the application
                endApp = EndApp(endApp);
            }
        }

        static void OperationHandeling(string operation, double[] RandomArray)
        {
            switch (operation)
            {
                case "1":
                    F1((double[])RandomArray.Clone());
                    break;
                case "2":
                    F2((double[])RandomArray.Clone());
                    break;
                case "3":
                    F3((double[])RandomArray.Clone());
                    break;
                case "4":
                    F4((double[])RandomArray.Clone());
                    break;
                case "5":
                    F5((double[])RandomArray.Clone());
                    break;
                case "6":
                    F1((double[])RandomArray.Clone());
                    helpingPrint(RandomArray);

                    F2((double[])RandomArray.Clone());
                    helpingPrint(RandomArray);

                    F3((double[])RandomArray.Clone());
                    helpingPrint(RandomArray);

                    F4((double[])RandomArray.Clone());
                    helpingPrint(RandomArray);

                    F5((double[])RandomArray.Clone());
                    helpingPrint(RandomArray);
                    break;
                case "1,2":
                case "1-2":
                    F1((double[])RandomArray.Clone());
                    Console.WriteLine("Your array is:");
                    printIt(RandomArray);
                    F2((double[])RandomArray.Clone());
                    break;
                case "1,3":
                    F1((double[])RandomArray.Clone());
                    F3((double[])RandomArray.Clone());
                    break;
                case "1,4":
                    F1((double[])RandomArray.Clone());
                    F4((double[])RandomArray.Clone());
                    break;
                case "1,5":
                    F1((double[])RandomArray.Clone());
                    F5((double[])RandomArray.Clone());
                    break;
                case "2,3":
                case "2-3":
                    F2((double[])RandomArray.Clone());
                    F3((double[])RandomArray.Clone());
                    break;
                case "2,4":
                    F2((double[])RandomArray.Clone());
                    F4((double[])RandomArray.Clone());
                    break;
                case "2,5":
                    F2((double[])RandomArray.Clone());
                    F5((double[])RandomArray.Clone());
                    break;
                case "3,4":
                case "3-4":
                    F3((double[])RandomArray.Clone());
                    F4((double[])RandomArray.Clone());
                    break;
                case "3,5":
                    F3((double[])RandomArray.Clone());
                    F5((double[])RandomArray.Clone());
                    break;
                case "4,5":
                case "4-5":
                    F4((double[])RandomArray.Clone());
                    F5((double[])RandomArray.Clone());
                    break;

                case "1-3":
                    F1((double[])RandomArray.Clone());
                    F2((double[])RandomArray.Clone());
                    F3((double[])RandomArray.Clone());
                    break;
                case "1-4":
                    F1((double[])RandomArray.Clone());
                    F2((double[])RandomArray.Clone());
                    F3((double[])RandomArray.Clone());
                    F4((double[])RandomArray.Clone());
                    break;
                case "1-5":
                    F1((double[])RandomArray.Clone());
                    F2((double[])RandomArray.Clone());
                    F3((double[])RandomArray.Clone());
                    F4((double[])RandomArray.Clone());
                    F5((double[])RandomArray.Clone());
                    break;


                case "2-4":
                    F2((double[])RandomArray.Clone());
                    F3((double[])RandomArray.Clone());
                    F4((double[])RandomArray.Clone());
                    break;
                case "2-5":
                    F2((double[])RandomArray.Clone());
                    F3((double[])RandomArray.Clone());
                    F4((double[])RandomArray.Clone());
                    F5((double[])RandomArray.Clone());
                    break;

                case "3-5":
                    F3((double[])RandomArray.Clone());
                    F4((double[])RandomArray.Clone());
                    F5((double[])RandomArray.Clone());
                    break;

            }
        }

        static string EnterMethod()
        {
            Console.WriteLine(@"Select which algorithm you want to perform:
                                                          1. Insertion sort
                                                          2. Bubble sort
                                                          3. Merge sort
                                                          4. Quick sort
                                                          5. Heap sort
                                                          6. All");
            string operation = Console.ReadLine();
            while (operation != "1" && operation != "2" && operation != "3" && operation != "4" && operation != "5" && operation != "6" 
                && operation != "1,2" && operation != "1,3" && operation != "1,4"&& operation != "1,5" 
                && operation != "2,3" && operation != "2,4" && operation != "2,5" 
                && operation != "3,4" && operation != "3,5" 
                && operation != "4,5"
                && operation != "1-2" && operation != "1-3" && operation != "1-4" && operation != "1-5"
                && operation != "2-3" && operation != "2-4" && operation != "2-5"
                && operation != "3-4" && operation != "3-5"
                && operation != "4-5")
            {
                Console.WriteLine("This is not valid operation.Try again.");
                operation = Console.ReadLine();
            }
            return operation;
        }
        /* Printing the array */
        static void printIt(double[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
        //this function is helping to see that our array is not changeing.
        static void helpingPrint(double[] arr)
        {
            Console.WriteLine("Your array is:");
            printIt(arr);
            Console.WriteLine();
        }
        static int InputSomethingsCount(string something)
        {
            int count;
            Console.WriteLine($"Please enter the size of an array that you want to sort:");
            String UserInput = Console.ReadLine();
            while (!int.TryParse(UserInput, out count) || count < 0)
            {
                Console.WriteLine($"Not a valid number, try again.");
                UserInput = Console.ReadLine();
            }
            return count;
        }

        static void FindMinimal(List<long> AllMiliseconds)
        {
            long min = AllMiliseconds[0];
            foreach (var item in AllMiliseconds)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            PrintGreen(min);
        }
        static void PrintGreen(long item)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Minimal running time: { item} ms");
            Console.ResetColor();
        }
        static void F1(double[] arr)
        {
            long memory1 = GC.GetTotalMemory(false);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Console.WriteLine("1. Insertion sort");
            double[] result = InsertionSort.Sort(arr);
            printIt(result);

            watch.Stop();
            AllMiliseconds.Add(watch.ElapsedMilliseconds);
            Console.WriteLine($"Running time: {watch.ElapsedMilliseconds} ms");

            long memory2 = GC.GetTotalMemory(false);
            long memory = memory2 - memory1;
            Console.WriteLine("Memory usage:{0}", memory);
            Console.WriteLine();
        }
        static void F2(double[] arr)
        {
            long memory1 = GC.GetTotalMemory(false);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Console.WriteLine("2. Bubble sort");
            double[] result = BubbleSort.Sort(arr);
            printIt(result);

            watch.Stop();
            AllMiliseconds.Add(watch.ElapsedMilliseconds);
            Console.WriteLine($"Running time: {watch.ElapsedMilliseconds} ms");

            long memory2 = GC.GetTotalMemory(false);
            long memory = memory2 - memory1;
            Console.WriteLine("Memory usage:{0}", memory);
            Console.WriteLine();
        }
        static void F3(double[] arr)
        {
            long memory1 = GC.GetTotalMemory(false);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Console.WriteLine("3. Merge sort");
            double[] result = MergeSort.Sort(arr);
            printIt(result);

            watch.Stop();
            AllMiliseconds.Add(watch.ElapsedMilliseconds);
            Console.WriteLine($"Running time: {watch.ElapsedMilliseconds} ms");

            long memory2 = GC.GetTotalMemory(false);
            long memory = memory2 - memory1;
            Console.WriteLine("Memory usage:{0}", memory);
            Console.WriteLine();
        }
        static void F4(double[] arr)
        {
            long memory1 = GC.GetTotalMemory(false);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Console.WriteLine("4. Quick sort");
            QuickSort.Sort(arr,0,arr.Length-1);
            printIt(arr);

            watch.Stop(); 
            AllMiliseconds.Add(watch.ElapsedMilliseconds);
            Console.WriteLine($"Running time: {watch.ElapsedMilliseconds} ms");

            long memory2 = GC.GetTotalMemory(false);
            long memory = memory2 - memory1;
            Console.WriteLine("Memory usage:{0}", memory);
            Console.WriteLine();
        }
        static void F5(double[] arr)
        {
            long memory1 = GC.GetTotalMemory(false);
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            Console.WriteLine("5. Heap sort");
            HeapSort.Sort(arr);
            printIt(arr);

            watch.Stop();
            AllMiliseconds.Add(watch.ElapsedMilliseconds);
            Console.WriteLine($"Running time: {watch.ElapsedMilliseconds} ms");

            long memory2 = GC.GetTotalMemory(false);
            long memory = memory2 - memory1;
            Console.WriteLine("Memory usage:{0}", memory);
            Console.WriteLine();
        }
        
        static bool EndApp(bool endApp)
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("If you want to end process press 'e'. If not, press enter");
            string key = Console.ReadLine();
            if (Equals(key, "e"))
            {
                endApp = true;
            }
            return endApp;
        }
       
    }
}
