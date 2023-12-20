using System;
using System.IO;

namespace StreamWriterExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\TEMP\file1.txt";
            string targetPath = @"D:\TEMP\file2.txt";


            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }

            }
            catch (IOException error)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(error.Message);
            }
        }
    }
}
