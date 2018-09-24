using Lab01.IONumbers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class IntArray
    {

        private const int MAX_ARRAY_LENGTH = 100_000;

        private int[] numbers;

        public int[] getNumbers()
        {
            return numbers;
        }

        public void generateRandomNumbers()
        {
            var generator = new ArrayGenerator();
            generator.generate();
            numbers = generator.GetArray();
        }

        public void writeInFile()
        {
            NumbersWriter.Write(numbers);
        }

        public static void generateAndWriteArray()
        {
            var intarr = new IntArray();
            intarr.generateRandomNumbers();
            intarr.writeInFile();
        }

        public static int[] GetArrayFromFile()
        {
            string[] strings = NumbersReader.Read().Split(' ');
            var intarr = new IntArray();
            var numbers = intarr.getNumbers();
            numbers = new int[MAX_ARRAY_LENGTH];

            for (int i = 0; i < MAX_ARRAY_LENGTH; i++)
            {
                int.TryParse(strings[i], out numbers[i]);
            }

            return numbers;
        }

    }
}
