using System;
using System.Globalization;

namespace ExercicioProposto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo R; 

            R = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            R.Largura= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Altura= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(R);

        }
    }
}
