using Lab01.exception;
using static Lab01.ionumbers.NumbersFileCredentials;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01.IONumbers
{
    public static class NumbersWriter
    {

        public static void Write(int[] numbers)
        {
            try
            {
                WriteNumbersInFile(numbers);
            }
            catch (Exception e)
            {
                throw new SortingException(e.Message);
            }
        }

        private static void WriteNumbersInFile(int[] numbers)
        {
            using (StreamWriter sw = new StreamWriter(FILE_PATH, true, Encoding.Default))
            {
                int len = numbers.Length;
                for (int i = 0; i < len; i++)
                {
                    sw.Write(numbers[i] + " ");
                }
            }
        }

    }
}
