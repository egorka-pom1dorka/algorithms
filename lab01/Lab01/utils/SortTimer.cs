using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.utils
{
    public class SortTimer
    {

        private const int ITERATIONS_AMOUNT = 10;

        private List<int[]> arrays;

        public SortTimer()
        {
            arrays = IntArray.GetArraysFromFile();
        }

        public int GetNAndPrintExecTimes()
        {
            double quicksortExecTime = GetExecutionTimeForQuickSort();
            Console.WriteLine($"Execution time for quicksort is {quicksortExecTime}");
            
            double hybridSortExecTime = 1_000_000;
            int n = 128;

            for (; hybridSortExecTime >= quicksortExecTime; n/=2)
            {
                hybridSortExecTime = GetExecutionTimeForHybridSort(n);
                Console.WriteLine($"Execution time for hybridsort (n = {n}) is {hybridSortExecTime}");
            }
            return n * 2;
        }

        private double GetExecutionTimeForQuickSort()
        {
            long wholeTime = 0;
            for (int i = 0; i < ITERATIONS_AMOUNT; i++)
            {
                for (int j = 0; j < IntArray.ARRAYS_AMOUNT; j++)
                {
                    int[] array = GetArrayCopy(arrays[j]);
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    Sorting.QuickSort(array);
                    stopwatch.Stop();

                    wholeTime += stopwatch.ElapsedMilliseconds;
                }


            }
            return wholeTime / ITERATIONS_AMOUNT / IntArray.ARRAYS_AMOUNT;
        }

        private int[] GetArrayCopy(int[] array)
        {
            int[] copy = new int[IntArray.ARRAY_LENGTH];
            array.CopyTo(copy, 0);
            return copy;
        }

        private double GetExecutionTimeForHybridSort(int k)
        {
            long wholeTime = 0;
            for (int i = 0; i < ITERATIONS_AMOUNT; i++)
            {
                for (int j = 0; j < IntArray.ARRAYS_AMOUNT; j++)
                {
                    int[] array = GetArrayCopy(arrays[0]);
                    var stopwatch = new Stopwatch();
                    stopwatch.Start();
                    Sorting.HybridSort(array, k);
                    stopwatch.Stop();

                    wholeTime += stopwatch.ElapsedMilliseconds;
                }    
            }
            return wholeTime / ITERATIONS_AMOUNT / IntArray.ARRAYS_AMOUNT;
        }

    }
}
