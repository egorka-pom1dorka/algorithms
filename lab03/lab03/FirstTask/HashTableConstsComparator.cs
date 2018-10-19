using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab03.FirstTask
{
    public static class HashTableConstsComparator
    {

        public static void ShowResults()
        {
            double knut = (Math.Sqrt(5) - 1) / 2;
            double[] consts = new double[] { knut, (Math.PI / 4), (Math.E / 3), ((Math.Sqrt(7) - 2) / 2) };

            var testData = DataGenerator.GenerateTestData();
            foreach (var @const in consts)
            {
                int min = GetMinHashTableListLength(@const, testData);
                Console.WriteLine($"================================================================");
                Console.WriteLine($"Min of max lists length for const {@const} is {min}");
                Console.WriteLine($"================================================================\n");
            }

        }

        private static int GetMinHashTableListLength(double @const, List<int[]> arrays)
        {
            int min = 99999999;
            for (int i = 0; i < arrays.Count(); i++)
            {
                var table = new HashTable(arrays[i].Length);
                table.SetConst(@const);
                FillTable(table, arrays[i]);

                //table.Show();

                int maxListLength = table.GetMaxListSize();
                min = maxListLength < min ? maxListLength : min;
            }
            return min;
        }

        private static void FillTable(HashTable table, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                table.Add(numbers[i], numbers[i]);
        }

    }
}
