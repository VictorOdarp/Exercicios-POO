using Multicast_Delegates.Services;
using System;

namespace Multicast_Delegates
{
    delegate void BynariNumericOperation (double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BynariNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
        }
    }
}