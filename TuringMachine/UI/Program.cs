using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuringMachine;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Turing.IsWordBinary("0001011100**");
            Turing.IsWordBinary("1111011a011b100**");

            Turing.ShowDistinctSymbolsAmount("**abbbaaa**");
            Turing.ShowDistinctSymbolsAmount("**bbb**");
            Turing.ShowDistinctSymbolsAmount("**bbabcc**");

            Console.ReadLine();
        }
    }
}
