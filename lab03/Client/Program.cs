using lab03.FirstTask;
using lab03.SecondTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Task 1: finding min number of max lists");
                HashTableConstsComparator.ShowResults();

                Console.WriteLine("\n");

                Console.WriteLine("Task 2: finding max number of adding new number in hashtable");
                HashTableAddingStepsComparator.ShowResults();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
        }
    }
}
