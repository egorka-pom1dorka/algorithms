using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine
{
    public static class ElementParser
    {

        public static int GetChanging(char rule)
        {
            switch (rule)
            {
                case '1':
                    return 1;
                case '2':
                    return -1;
                default:
                    return 0;
            }
        }

        public static string GetWordRewrite(string word, string path, int position)
        {
            return word.Substring(0, position) + path[1] + word.Substring(position + 1);
        }

        public static bool CheckEnd(char position)
        {
            if (position == 'n')
            {
                Console.Out.WriteLine();
                Console.Out.WriteLine("No");
                return true;
            }

            if (position == 'y')
            {
                Console.Out.WriteLine();
                Console.WriteLine("Yes");
                return true;
            }

            return false;
        }

    }
}
