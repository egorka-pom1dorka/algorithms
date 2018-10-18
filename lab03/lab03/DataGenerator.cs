using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03
{
    public static class DataGenerator
    {

        private static int ARRAY_SIZE = 1000;
        private static int MIN_NUMBER = 0;
        private static int MAX_NUMBER = 1000;
        private static int ARRAYS_AMOUNT = 50;

        public static List<int[]> GenerateTestData()
        {
            var arrays = new List<int[]>();

            for (int i = 0; i < ARRAYS_AMOUNT; i++)
            {
                int[] numbers = GenerateIntArray();
                arrays.Add(numbers);
            }

            return arrays;
        }

        private static int[] GenerateIntArray()
        {
            var rand = new Random();
            int[] numbers = new int[ARRAY_SIZE];

            for (int i = 0; i < numbers.Length; i++)
            {
                int random = rand.Next(MIN_NUMBER, MAX_NUMBER);
                numbers[i] = random;
            }

            return numbers;
        }

    }
}
