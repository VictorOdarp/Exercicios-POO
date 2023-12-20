using ExercicioResolvido.Entities;
using System;
using System.Globalization;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter a full file patch: ");
            string SourcePath = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(SourcePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vet = sr.ReadLine().Split(",");
                        string name = vet[0];
                        double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
                        products.Add(new Product(name, price));
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("An error occurred");
                char.Parse(error.Message);
            }

            var Average = products.Average(p => p.Price);
            Console.WriteLine("Average price: " +  Average.ToString("F2", CultureInfo.InvariantCulture));

            var Names = products.Where(p => p.Price < Average).OrderByDescending(p => p.Name);
            foreach (Product product in Names)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}