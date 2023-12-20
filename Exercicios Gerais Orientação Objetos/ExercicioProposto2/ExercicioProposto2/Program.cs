using System;
using System.Globalization;

namespace ExercicioProposto2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Funcionario1, Funcionario2;

            Funcionario1 = new Funcionario();
            Funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            Funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Funcionario1.Salário = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            Funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Funcionario2.Salário = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double média;
            média = (Funcionario1.Salário + Funcionario2.Salário) / 2.0;

            Console.WriteLine("Salário médio = " + média.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
