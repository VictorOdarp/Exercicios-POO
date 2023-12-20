using System;
using System.IO;

namespace PathDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\TEMP\myfolder\file.txt";

            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            // Console.WriteLine("DirectorySeparatorChar: " + Path.AltDirectorySeparatorChar(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

        }
    }
}
