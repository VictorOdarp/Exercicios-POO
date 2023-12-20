

namespace ExercicioResolvido4
{
    internal class Calculadora
    {
        public double PI = 3.14;

        public double Circunferencia(double r)
        {
            return 2.0 * PI * r;
        }
        public double Volume(double r)
        {
            return 4.0 * PI * Math.Pow(r, 3.0) / 3.0;
        }
    }
}
