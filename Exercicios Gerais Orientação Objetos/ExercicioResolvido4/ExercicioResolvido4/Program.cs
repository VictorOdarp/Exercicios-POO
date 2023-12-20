using System;
using System.Globalization;

namespace ExercicioResolvido4
{

    // VERSÃO 2: classe Calculadora com membros de instância
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Calc = new Calculadora();

            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Circ = Calc.Circunferencia(raio);
            double Vol = Calc.Volume(raio);

            Console.WriteLine("Circunferência: " + Circ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume: " + Vol.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor de PI: " + Calc.PI.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
