using ExercicioResolvidoEHP.Entities;
using System;
using System.Globalization;

namespace ExercicioResolvidoEHP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1;  i <= N; i++)
            {
                Console.WriteLine("Employee #" + i + " data: ");
                Console.Write("Outsourced (y/n)? ");
                char Verificação = char.Parse(Console.ReadLine());

                if (Verificação == 'y')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourceEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
                
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name + " -  $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

            
        }
    }
}