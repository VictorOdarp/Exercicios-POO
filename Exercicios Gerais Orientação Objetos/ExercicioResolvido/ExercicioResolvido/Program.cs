using System;
using System.Globalization;

namespace ExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");

            double soma = 0.0;
            double P = 0.0;

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = x.A + x.B + x.C;

            P = soma / 2.0;
            double AreaX = Math.Sqrt(P * (P - x.A) * (P - x.B) * (P - x.C));

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            soma = 0.0;
            P = 0.0;

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            soma = y.A + y.B + y.C;

            P = soma / 2.0;
            double AreaY = Math.Sqrt(P * (P - y.A) * (P - y.B) * (P - y.C));

            Console.WriteLine("Area de X = " + AreaX.ToString("F4"), CultureInfo.InvariantCulture);
            Console.WriteLine("Area de Y = " + AreaY.ToString("F4"), CultureInfo.InvariantCulture);

            if (AreaX > AreaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }




        }
    }
}
