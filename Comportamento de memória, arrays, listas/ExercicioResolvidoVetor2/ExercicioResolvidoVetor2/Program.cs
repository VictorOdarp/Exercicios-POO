using System;
using System.Globalization;

namespace ExercicioResolvidoVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            Produto[] produtos = new Produto[N];

            for (int i = 0;  i < N; i++)
            {
                string nome = Console.ReadLine();  
                double preço = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i] = new Produto(nome, preço);
            }

            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma = soma + produtos[i].Preço;
                Console.WriteLine(produtos[i].Nome);
            }

            double média = soma / N;

            Console.WriteLine();
            Console.WriteLine("AVERAGE PRICE = " + média.ToString("F2"), CultureInfo.InvariantCulture);

            
        }
    }
}
