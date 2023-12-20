using ExercicioProposto1.Entities;
using System;

namespace ExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Aluno> CourseA = new HashSet<Aluno>();
            HashSet<Aluno> CourseB = new HashSet<Aluno>();
            HashSet<Aluno> CourseC = new HashSet<Aluno>();

            Console.Write("How many students for Course A? ");
            int Quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < Quant; i++)
            {
                int id = int.Parse(Console.ReadLine());
                CourseA.Add(new Aluno(id));
            }
           
            Console.Write("How many students for Course B? ");
            Quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < Quant; i++)
            {
                int id = int.Parse(Console.ReadLine());
                CourseB.Add(new Aluno(id));
            }
           
            Console.Write("How many students for Course C? ");
            Quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < Quant; i++)
            {
                int id = int.Parse(Console.ReadLine());
                CourseC.Add(new Aluno(id));
            }

            HashSet<Aluno> all = new HashSet<Aluno>(CourseA);
            all.UnionWith(CourseB);
            all.UnionWith(CourseC);
            Console.WriteLine("Total students: " + all.Count);


        }
    }
}
