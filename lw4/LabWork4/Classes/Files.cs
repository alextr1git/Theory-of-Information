using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;

namespace LabWork4
{
    internal class FileWork
    {
        public static void writeDS(string pathToFile, string rawdata, BigInteger DS) //add S to File and write it down
        {
            File.WriteAllText(pathToFile, rawdata + " " + DS.ToString());
        }

        public static BigInteger getDS(string FilePath) // Get ECP from file
        {
            string[] dataarr = File.ReadAllText(FilePath).Split(' ');

            return BigInteger.Parse(dataarr[dataarr.Length - 1]);
        }

        public static string getContent(string FilePath)
        {
            string[] dataarr = File.ReadAllText(FilePath).Split(' ');

            string content = string.Empty;

            for (int i = 0; i < dataarr.Length - 1; i++)
                content += dataarr[i];

            return content;
        }
    }
}
