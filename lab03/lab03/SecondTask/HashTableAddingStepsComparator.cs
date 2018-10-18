using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03.SecondTask
{
    public static class HashTableAddingStepsComparator
    {

        public static void ShowResults()
        {

            var testData = DataGenerator.GenerateTestData();
            int max = GetMaxHashTableListLength(testData);
            Console.WriteLine($"================================================================");
            Console.WriteLine($"Max number of attempts is {max}");
            Console.WriteLine($"================================================================\n");

        }

        private static int GetMaxHashTableListLength(List<int[]> arrays)
        {
            int maxListLength = 0;
            for (int i = 0; i < arrays.Count(); i++)
            {
                var table = new LinearAddressingHashTable(arrays[i].Length);
                int currTableMaxLength = GetMaxStempAmount(table, arrays[i]);
                maxListLength = currTableMaxLength > maxListLength ? currTableMaxLength : maxListLength;
            }
            return maxListLength;
        }

        private static int GetMaxStempAmount(LinearAddressingHashTable table, int[] numbers)
        {
            int max = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                table.Add(i, numbers[i]);
                max = table.GetSteps() > max ? table.GetSteps() : max;
            }
            return max;
        }



    }
}
