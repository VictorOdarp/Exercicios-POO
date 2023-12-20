using ExercicioPropostoMétodosAbstratos.Entities;
using System;
using System.Globalization;


namespace ExercicioPropostoMétodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> contribuintes = new List<Contribuintes>();

            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Tax payer #" + i + " data:");
                Console.Write("Individual or company (i/c)? ");
                char Validação = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (Validação == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    contribuintes.Add(new PessoaFisica(name, anualIncome, healthExpeditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    contribuintes.Add(new PessoaJuridica(name, anualIncome, employees));
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double sum = 0.0; 

            foreach (Contribuintes contri in contribuintes)
            {
                sum += contri.totalImposto();
                Console.WriteLine(contri);
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
