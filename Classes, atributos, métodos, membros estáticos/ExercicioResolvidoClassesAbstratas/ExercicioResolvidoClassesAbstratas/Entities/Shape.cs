

using ExercicioResolvidoClassesAbstratas.Entities.Enums;

namespace ExercicioResolvidoClassesAbstratas.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape()
        {

        }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double area();
        

    }
}
