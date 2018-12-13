using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = new int[] { 1, 2, 1, 4, 4, 5, 6, 3, 2, 5, 8, 6, 7, 8, 9 };
            var nums = Dynamic.GetMaxNonDesceasingSequence(sequence);
            foreach (var n in nums)
                Console.Write(n + " ");
            Console.WriteLine();

            var polyndrom = Dynamic.GetMaxPolyndrom("egoolrrooko");
            Console.WriteLine(polyndrom);

            var amount = Dynamic.GetHoursesVariants(8, 9);
            Console.WriteLine(amount);

            var items = new List<Item>() {
                new Item(3, 2, 4),
                new Item(3, 1, 3),
                new Item(3, 3, 6),
                new Item(3, 5, 10),
                new Item(3, 3, 7)
            };
            var res = Dynamic.BackPack(items, 11);
            Console.WriteLine(res);

            Console.WriteLine();
        }
    }
}
