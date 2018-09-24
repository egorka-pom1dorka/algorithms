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

        public const int ITERATIONS_AMOUNT = 50;

        private Stopwatch stopwatch;

        public SortTimer()
        {
            stopwatch = new Stopwatch();
        }

        public decimal GetExecutionTimeFromQuickSort()
        {
            int counter = 0;
            long wholeTime = 0;
            while (counter < ITERATIONS_AMOUNT)
            {
                int[] numbers = IntArray.GetArrayFromFile();

                stopwatch.Start();
                Sorting.QuickSort(numbers, 0, numbers.Length - 1);
                stopwatch.Stop();

                wholeTime += stopwatch.ElapsedMilliseconds;
                counter++;
            }

            return wholeTime / ITERATIONS_AMOUNT;
        }

        public decimal GetExecutionTimeFromHybridSort(int k)
        {
            int counter = 0;
            long wholeTime = 0;
            while (counter < ITERATIONS_AMOUNT)
            {
                int[] numbers = IntArray.GetArrayFromFile();
                
                stopwatch.Start();
                Sorting.HybridSort(numbers, 0, numbers.Length - 1, k);
                stopwatch.Stop();

                wholeTime += stopwatch.ElapsedMilliseconds;
                counter++;
            }

            return wholeTime / ITERATIONS_AMOUNT;
        }

    }
}
