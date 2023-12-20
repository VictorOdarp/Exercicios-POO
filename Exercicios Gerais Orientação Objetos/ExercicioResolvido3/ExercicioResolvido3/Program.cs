using System;
using System.Globalization;

namespace ExercicioResolvido3
{
    class Program
    {
        // VERSÃO 1: MÉTODOS NA PRÓPRIA CLASSE DO PROGRAMA

        static double PI = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Circ = Circunferencia(Raio);
            double Vol = Volume(Raio);

            Console.WriteLine("Circunferência: " + Circ.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Volume: " + Vol.ToString("F2"), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor de PI: " + PI);
        }   

        static double Circunferencia(double r)
        {
            return 2.0 * PI * r;
        }
        static double Volume(double r)
        {
            return 4.0 * PI * Math.Pow(r, 3.0) / 3.0;
        }




    }
}