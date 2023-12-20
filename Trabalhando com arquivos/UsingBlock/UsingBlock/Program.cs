using System;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\TEMP\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException error)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(error.Message);
            }
        }
    }
}