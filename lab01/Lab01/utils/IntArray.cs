using Lab01.IONumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public static class IntArray
    {

        public const int ARRAY_LENGTH = 100_000;
        public const int ARRAYS_AMOUNT= 50;

        public static void appendGeneratedNumbersInFile()
        {
            int[] numbers = generateRandomNumbers();
            writeInFile(numbers);
        }

        private static int[] generateRandomNumbers()
        {
            var generator = new ArrayGenerator();
            generator.generate();
            return generator.GetArray();
        }

        private static void writeInFile(int[] numbers)
        {
            NumbersWriter.Write(numbers);
        }

        public static List<int[]> GetArraysFromFile()
        {
            string[] strings = NumbersReader.Read().Split(' ');

            List<int[]> arrays = new List<int[]>();

            for(int i = 1; i <= ARRAYS_AMOUNT; i++)
            {
                int[] numbers = new int[ARRAY_LENGTH];
                for (int j = 0; j < ARRAY_LENGTH; j++)
                {
                    int.TryParse(strings[i * j], out numbers[j]);
                }
                arrays.Add(numbers);
            }

            return arrays;
        }

    }
}
