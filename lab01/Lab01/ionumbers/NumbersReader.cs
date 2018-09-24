using static Lab01.ionumbers.NumbersFileCredentials;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab01.exception;

namespace Lab01.IONumbers
{
    public class NumbersReader
    {

        public static string Read()
        {
            try
            {
                return GetFileData();
            }
            catch (Exception e)
            {
                throw new SortingException(e.Message);
            }
        }

        private static string GetFileData()
        {
            using (StreamReader sr = new StreamReader(FILE_PATH, Encoding.Default))
            {
                return sr.ReadToEnd();
            };
        }

    }
}
