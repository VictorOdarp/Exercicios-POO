using System;
using System.Globalization;

namespace ExercicioResolvido5
{

    // VERSÃO 3: classe Calculadora com método estátic
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Circ = Calculadora.Circunferencia(raio);
            double Vol = Calculadora.Volume(raio);

            Console.WriteLine("Circunferência: " + Circ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume: " + Vol.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor de PI: " + Calculadora.PI.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}