using ExercicioProposto.Entities;
using System;
using System.Globalization;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter your salary: ");
            double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Funcionary> funcionaries = new List<Funcionary>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vet = sr.ReadLine().Split(",");
                        string name = vet[0];
                        string email = vet[1];
                        double salary = double.Parse(vet[2], CultureInfo.InvariantCulture);
                        funcionaries.Add(new Funcionary(name, email, salary));
                    }
                }
            } 
            catch (Exception error)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(error.Message);
            }

            Console.WriteLine("Email of people whose salary is more than income:");
            var topsEmail = funcionaries.Where(p => p.Salary > income).OrderBy(p => p.Email);
            foreach (var funcionary in topsEmail)
            {
                Console.WriteLine(funcionary.Email);
            }

            Console.Write("Sum of salary of people whose name starts with 'M': ");
            var SumSalary = funcionaries.Where(p => p.Name[0] == 'M').Sum(p  => p.Salary);
            Console.WriteLine(SumSalary.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
