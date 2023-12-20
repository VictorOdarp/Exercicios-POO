using System;
using System.Globalization;

namespace ExercicioResolvidoVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            int N;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];


            for (int i = 0;  i < N; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma = soma + vet[i]; 
            }

            double médiaAltura = soma / N;

            Console.WriteLine("AVERAGE HEIGHT = " + médiaAltura.ToString("F2"), CultureInfo.InvariantCulture);


        }
    }
}


