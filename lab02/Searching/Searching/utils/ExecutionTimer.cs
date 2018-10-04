using Searching.utils;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public static class ExecutionTimer
    {

        public const int ITERATIONS_AMOUNT = 500_000;

        public static void ShowResults()
        {
            for (int i = 128; i >= 1; i -= 4)
            {
                int[] numbers = GetRandomNumbers(i);
                int element = GetSearchableElement();

                Console.Write($"Array length = {i}. ");

                var binaryTime = GetBinaryExecutionTime(numbers, element);
                Console.Write($"Binary: {binaryTime}. ");

                var interpolationTime = GetInterpolationExecutionTime(numbers, element);
                Console.Write($"Interpolation: {interpolationTime}. ");

                Console.WriteLine();
            }
        }

        public static int[] GetRandomNumbers(int length)
        {
            var generator = new ArrayGenerator(length);
            generator.generate();
            return generator.GetArray();
        }

        public static int GetSearchableElement()
        {
            return new Random().Next(10, 1_000_000);
        }

        public static long GetBinaryExecutionTime(int[] numbers, int element)
        {
            var watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < ITERATIONS_AMOUNT; i++)
            {
                int index = Search.Binary(numbers, element);
            }

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }

        public static long GetInterpolationExecutionTime(int[] numbers, int element)
        {
            var watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < ITERATIONS_AMOUNT; i++)
            {
                int index = Search.Interpolation(numbers, element);
            }

            watch.Stop();
            return watch.ElapsedMilliseconds;
        }
    }
}
