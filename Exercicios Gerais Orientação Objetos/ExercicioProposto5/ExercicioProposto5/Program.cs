using System;
using System.Globalization;

namespace ExercicioProposto5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno Aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            
            Aluno.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite as três notas do aluno: ");
            
            Aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (Aluno.Aprovado())
            {
                Console.WriteLine("NOTA FINAL = " + Aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + Aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + Aluno.NotaFaltante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }




        }
    }
}
