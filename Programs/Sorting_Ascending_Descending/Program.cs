using System;
using System.Collections.Generic;

namespace poc1q3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numArray = new int[] { 5, 4, 3, 2, 1, 6, 7, 8, 9, 10 };
            
            Console.WriteLine("The Numbers in the Array");
            Console.WriteLine(string.Join(",", numArray));
            Console.WriteLine();

            Console.WriteLine("The Array in Ascending Order");
            ascending(numArray);
            Console.WriteLine(string.Join(",", numArray));
            Console.WriteLine();

            Console.WriteLine("The Array in Descending Order");
            descending(numArray);
            Console.WriteLine(string.Join(",", numArray));
            Console.WriteLine();
        }

        static void ascending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void descending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
