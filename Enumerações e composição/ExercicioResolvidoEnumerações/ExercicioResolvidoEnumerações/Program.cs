using ExercicioResolvidoEnumerações.Entities;
using ExercicioResolvidoEnumerações.Entities.Enum;
using System;
using System.Globalization;

namespace ExercicioResolvidoEnumerações
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter departement's name: ");
            string namedepartament = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior) : ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament departament = new Departament(namedepartament);
            Worker worker = new Worker(name, level, salary, departament);
            
            Console.Write("How many contract to this worker? ");
            int contract = int.Parse(Console.ReadLine());

            for (int i = 1; i <= contract; i++)
            {
                Console.WriteLine("Enter #" +  i + " contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract Contract = new HourContract(date, valueperhour, hours);
                worker.addContract(Contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string MonthAndYear = Console.ReadLine();
            int month = int.Parse(MonthAndYear.Substring(0, 2));
            int year = int.Parse(MonthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for " + MonthAndYear + ": " + worker.income(year, month).ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}