using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    public class Turing
    {

        /**
         * In table:
         * index 0 is symbol for compare
         * index 1 is symbol to rewrite
         * index 2 is moving direction (1 - right, 2 - left)
         * index 3 is next vertex
         * symbols * and s - is empty symbols
         */

        public static void IsWordBinary(string word)
        {
            string[] table = new string[] { "0010", "1110", "aa0n", "bb0n", "*11y" };
            char position = '0';
            int i = 0;
            Console.WriteLine("Positiion " + i + ", word is " + word);

            while (true)
            {
                char letter = word[i];
                foreach (var path in table)
                {
                    if (letter == path[0])
                    {
                        word = ElementParser.GetWordRewrite(word, path, i);
                        i += ElementParser.GetChanging(path[2]);
                        position = path[3];

                        if (ElementParser.CheckEnd(position))
                        {
                            Console.WriteLine();
                            return;
                        }

                        Console.WriteLine("Positiion " + i + ", word is " + word);
                        break;
                    }
                }
                
            }

        }

        public static void ShowDistinctSymbolsAmount(string word)
        {
            string[][] table = new string[6][];
            table[0] = new string[] { "as11", "bs12", "cs13", "ss15", "**10" };
            table[1] = new string[] { "as11", "bb11", "cc11", "ss11", "**24" };
            table[2] = new string[] { "aa12", "bs12", "cc12", "ss12", "**24" };
            table[3] = new string[] { "aa13", "bb13", "cs13", "ss13", "**24" };
            table[4] = new string[] { "aa24", "bb24", "cc24", "ss24", "**10" };
            table[5] = new string[] { "aa00", "bb00", "cc00", "ss15", "**0y" };

            int position = 0;
            int letterNumber = 0;

            while (true)
            {
                char letter = word[letterNumber];
                foreach (var path in table[position])
                {
                    if (letter == path[0])
                    {
                        word = ElementParser.GetWordRewrite(word, path, letterNumber);
                        letterNumber += ElementParser.GetChanging(path[2]);

                        if (position == 0 && (path[0] == 'a' || path[0] == 'b' || path[0] == 'c'))
                        {
                            Console.Write("|");
                        }

                        if (ElementParser.CheckEnd(path[3]))
                        {
                            Console.WriteLine();
                            return;
                        }

                        position = (int)path[3] - 48;
                        break;
                    }
                }

            }
        }

    }

}
