using System;
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\temp\teste1.txt";
            string targetPath = @"D:\temp\teste2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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
