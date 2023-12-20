

namespace ExercicioProposto6
{
    internal class CalculadoraDolar
    {
        public static double IOF = 6.0;
        
        public static double CotaçãoEDolar(double cotação, double dolar)
        {
            double ValorTotal = cotação * dolar;
            return ValorTotal + IOF / 100 * ValorTotal;
        }

        
    }
}
