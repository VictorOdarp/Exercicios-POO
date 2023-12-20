using ExercicioProposto4;
using System;
using System.Globalization;


namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionário F;

            F = new Funcionário();

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + F);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double Quant = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(Quant);

            Console.WriteLine();
            Console.Write("Dados atualizados: ");
            Console.Write(F);
        }
    }
}
