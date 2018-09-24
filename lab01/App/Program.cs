using Lab01;
using Lab01.IONumbers;
using Lab01.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var timer = new SortTimer();

                decimal hybridSortExecTime = 0, quickSortExecTime = 0;
                int k = 6;

                //quickSortExecTime = timer.GetExecutionTimeFromQuickSort();
                //Console.WriteLine($"QuickSort time is {quickSortExecTime}");

                hybridSortExecTime = timer.GetExecutionTimeFromHybridSort(k);
                Console.WriteLine($"HybridSort time is {hybridSortExecTime} for k = {k}");

                //Console.WriteLine($"Final exec time for hybrid sorting is {hybridSortExecTime} and k is {k}");

                Console.WriteLine("That's all");
            }   
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void PrintArray(int[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("\n");
        }

        public static void PrintArray(long[] arr)
        {
            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine("\n");
        }

    }
}
