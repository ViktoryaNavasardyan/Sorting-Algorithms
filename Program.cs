using SortClasses.Models;
using System;

namespace SortClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //Checking();
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
                printIt(RandomArray);
                string operation = EnterMethod();
                double[] result = new double[N];
                switch (operation)
                {
                    case "1":
                        F1(RandomArray);
                        break;
                    case "2":
                        F2(RandomArray); 
                        break;
                    case "3":
                        F3(RandomArray);
                        break;
                    case "4":
                        F4(RandomArray);
                        break;
                    case "5":
                        F5(RandomArray);
                        break;
                    case "6":
                        F1(RandomArray); F2(RandomArray); F3(RandomArray); F4(RandomArray); F5(RandomArray);
                        break;
                    case "1,2":
                    case "1-2":
                        F1(RandomArray);
                        printIt(RandomArray); F2(RandomArray);
                        break;
                    case "1,3":
                        F1(RandomArray); F3(RandomArray);
                        break;
                    case "1,4":
                        F1(RandomArray); F4(RandomArray);
                        break;
                    case "1,5":
                        F1(RandomArray); F5(RandomArray);
                        break;
                    case "2,3":
                    case "2-3":
                        F2(RandomArray); F3(RandomArray);
                        break;
                    case "2,4":
                        F2(RandomArray); F4(RandomArray);
                        break;
                    case "2,5":
                        F2(RandomArray); F5(RandomArray);
                        break;
                    case "3,4":
                    case "3-4":
                        F3(RandomArray);
                        F4(RandomArray);
                        break;
                    case "3,5":
                        F3(RandomArray); F5(RandomArray);
                        break;
                    case "4,5":
                    case "4-5":
                        F4(RandomArray); F5(RandomArray);
                        break;
                    
                    case "1-3":
                        F1(RandomArray); F2(RandomArray); F3(RandomArray);
                        break;
                    case "1-4":
                        F1(RandomArray); F2(RandomArray); F3(RandomArray); F4(RandomArray);
                        break;
                    case "1-5":
                        F1(RandomArray); F2(RandomArray); F3(RandomArray); F4(RandomArray); F5(RandomArray);
                        break;
                    
                       
                    case "2-4":
                        F2(RandomArray); F3(RandomArray); F4(RandomArray);
                        break;
                    case "2-5":
                        F2(RandomArray); F3(RandomArray); F4(RandomArray); F5(RandomArray);
                        break;
                    
                    case "3-5":
                        F3(RandomArray); F4(RandomArray); F5(RandomArray);
                        break;
                    
                }
                //ending the application
                endApp = EndApp(endApp);
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
        
        static void F1(double[] arr)
        {
            Console.WriteLine("1. Insertion sort");
            InsertionSort.Sort(arr);
            printIt(arr);
            Console.WriteLine();
        }
        static void F2(double[] arr)
        {
            Console.WriteLine("2. Bubble sort");
            BubbleSort.Sort(arr);
            printIt(arr);
            Console.WriteLine();
        }
        static void F3(double[] arr)
        {
            Console.WriteLine("3. Merge sort");
            MergeSort.Sort(arr);
            printIt(arr);
            Console.WriteLine();
        }
        static void F4(double[] arr)
        {
            Console.WriteLine("4. Quick sort");
            QuickSort.Sort(arr,0,arr.Length-1);
            printIt(arr);
            Console.WriteLine();
        }
        static void F5(double[] arr)
        {
            Console.WriteLine("5. Heap sort");
            HeapSort.Sort(arr);
            printIt(arr);
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
        //Checking functions
        static void Checking()
        {
            double[] arr = { 90, 76, 45, 93, 68, 13, 98 };
            printIt(arr);
            Console.WriteLine();

            Console.WriteLine("Sorted array by insertation sort");
            InsertionSort.Sort(arr);
            printIt(arr);
            Console.WriteLine();

            Console.WriteLine("Sorted array by bubble sort");
            BubbleSort.Sort(arr);
            printIt(arr);
            Console.WriteLine();

            Console.WriteLine("Sorted array by merge sort");
            double[] a = MergeSort.Sort(arr);
            printIt(a);
            Console.WriteLine();

            Console.WriteLine("Sorted array by quick sort");
            QuickSort.Sort(arr, 0, arr.Length - 1);
            printIt(arr);
            Console.WriteLine();

            Console.WriteLine("Sorted array by heap sort");
            HeapSort.Sort(arr);
            printIt(arr);
        }
    }
}
