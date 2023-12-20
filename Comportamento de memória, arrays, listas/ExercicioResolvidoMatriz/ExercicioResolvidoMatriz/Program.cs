using System;

namespace ExercicioResolvidoMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matriz = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    matriz[i,j] = int.Parse(vet[j]);    
                }
            }

            Console.WriteLine("Main diagonal: ");
            int Cont = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }

                    if (matriz[i,j] < 0)
                    {
                        Cont++;
                    }

                }
            }
            
            Console.WriteLine();
            Console.WriteLine("Negative numbers = " + Cont);


        }
    }
}


