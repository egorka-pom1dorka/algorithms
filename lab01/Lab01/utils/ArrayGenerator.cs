using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class ArrayGenerator
    {

        private const int ARRAY_LENGTH = 100_000;
        private const int MIN_NUMBER_VALUE = 1;
        private const int MAX_NUMBER_VALUE = 1_000_000_000;

        private int[] numbers;
        private Random rand;

        public ArrayGenerator()
        {
            numbers = new int[ARRAY_LENGTH];
            rand = new Random();
        }

        public void generate()
        {
            for (int i = 0; i < ARRAY_LENGTH; i++)
            {
                numbers[i] = GetRandomNumber();
            }
        }

        private int GetRandomNumber()
        {
            return rand.Next(MIN_NUMBER_VALUE, MAX_NUMBER_VALUE);
        }

        public int[] GetArray()
        {
            return numbers;
        }

    }
}
