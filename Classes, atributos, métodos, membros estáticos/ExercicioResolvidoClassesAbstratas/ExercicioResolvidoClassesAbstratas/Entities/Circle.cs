using ExercicioResolvidoClassesAbstratas.Entities.Enums;

namespace ExercicioResolvidoClassesAbstratas.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle()
        {

        }

        public Circle(double radius, Color color) : base(color) 
        {
            Radius = radius;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}
