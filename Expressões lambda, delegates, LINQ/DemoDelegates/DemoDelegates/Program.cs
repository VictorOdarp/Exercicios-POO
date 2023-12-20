using DemoDelegates.Services;
using System;

namespace Demo
{
    delegate double BynariNumericOperation (double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BynariNumericOperation op = CalculationService.Sum;

            double result = op(a, b);
            Console.WriteLine(result);

        }
    }
}