using System;
using System.Globalization;

namespace ExercicioProposto6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotação = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos doláres você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ValorTotal = CalculadoraDolar.CotaçãoEDolar(cotação, dolar);

            Console.WriteLine("Valor a ser pago em reais = " + ValorTotal.ToString("F2"), CultureInfo.InvariantCulture);
           
           


        }
    }
}