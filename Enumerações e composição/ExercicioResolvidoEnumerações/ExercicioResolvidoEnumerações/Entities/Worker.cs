using ExercicioResolvidoEnumerações.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;


namespace ExercicioResolvidoEnumerações.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double salary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = salary;
            Departament = departament;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(int year, int month)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year ==  year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }

            return sum;
        }

    }

}