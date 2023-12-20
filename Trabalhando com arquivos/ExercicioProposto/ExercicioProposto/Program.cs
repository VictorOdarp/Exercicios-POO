using ExercicioProposto.Entities;
using System;
using System.Globalization;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file name");
            string sourceFileName = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourceFileName);

                string sourceFolderName = Path.GetDirectoryName(sourceFileName);
                string targetFolderName = sourceFolderName + @"\out";
                string targetFileName = targetFolderName + @"\summary.csv";

                Directory.CreateDirectory(targetFolderName);

                using (StreamWriter SW = File.AppendText(targetFileName))
                {
                    foreach (string line in lines)
                    {
                        string[] strings = line.Split(',');
                        string name = strings[0];
                        double price = double.Parse(strings[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(strings[2]);

                        Product product = new Product(name, price, quantity);

                        SW.WriteLine(product.Name + "," + product.TotalPrice().ToString("F2", CultureInfo.InvariantCulture));

                    }
                }

            }
            catch (IOException error)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(error.Message);
            }
        }
    }
}