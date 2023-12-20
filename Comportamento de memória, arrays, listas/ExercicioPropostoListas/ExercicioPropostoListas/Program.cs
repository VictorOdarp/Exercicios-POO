using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ExercicioPropostoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= N; i++)
            {
                Console.WriteLine("Emplyoee #" + i + ":"); 
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Funcionario funcionario = new Funcionario(id, name, salary);
                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine();
                
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idVerificação = int.Parse(Console.ReadLine());

            Funcionario int1 = list.Find(x => x.Id == idVerificação);

            if (int1 != null)
            {
                Console.Write("Enter the percentage: ");
                double Percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                int1.AumentarSalario(Percentage);
                
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list if employees: ");

            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

            

            



          

            
        }
    }
}