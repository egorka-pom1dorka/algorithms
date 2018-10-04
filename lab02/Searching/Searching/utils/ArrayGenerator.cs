using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching.utils
{
    public class ArrayGenerator
    {
        public const int ARRAY_LENGTH = 100_000_000;
        private const int MIN_NUMBER_VALUE = 1;
        private const int MAX_NUMBER_VALUE = 1_000_000_000;

        private int[] numbers;
        private Random rand;
        private int length;

        public ArrayGenerator()
        {
            numbers = new int[ARRAY_LENGTH];
            length = ARRAY_LENGTH;
            rand = new Random();
        }

        public ArrayGenerator(int length)
        {
            numbers = new int[length];
            this.length = length;
            rand = new Random();
        }

        public void generate()
        {
            int min = MIN_NUMBER_VALUE;
            for (int i = 0; i < length; i++)
            {
                int max = min + rand.Next(1, 10);
                numbers[i] = GetRandomNumber(min, max);
                min = numbers[i];
            }
        }

        private int GetRandomNumber(int min, int max)
        {
            return rand.Next(min, max);
        }

        public int[] GetArray()
        {
            return numbers;
        }

    }
}
