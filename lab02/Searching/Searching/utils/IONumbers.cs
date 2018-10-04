using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching.utils
{
    public class IONumbers
    {

        private const string FILE_PATH = @".\..\..\..\numbers.txt";

        public static void AppendRandomNumbersInFile()
        {
            int[] numbers = generateRandomNumbers();
            Write(numbers);
        }

        private static int[] generateRandomNumbers()
        {
            var generator = new ArrayGenerator();
            generator.generate();
            return generator.GetArray();
        }

        private static void Write(int[] numbers)
        {
            try
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
            catch (Exception e)
            {
                // Exception handling
            }
        }

        public static int[] GetNumbersFromFile()
        {
            string[] strings = ReadFileData().Split(' ');

            int[] numbers = new int[ArrayGenerator.ARRAY_LENGTH];
            for (int i = 0; i < ArrayGenerator.ARRAY_LENGTH; i++)
            {
                int.TryParse(strings[i], out numbers[i]);
            }
            return numbers;
        }

        private static string ReadFileData()
        {
            try
            {
                using (StreamReader sr = new StreamReader(FILE_PATH, Encoding.Default))
                {
                    return sr.ReadToEnd();
                };
            }
            catch (Exception e)
            {
                return "";
            }
        }

    }
}
