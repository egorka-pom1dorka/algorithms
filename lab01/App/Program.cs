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
                int n = timer.GetNAndPrintExecTimes();
                Console.WriteLine($"Final n = {n}");

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
