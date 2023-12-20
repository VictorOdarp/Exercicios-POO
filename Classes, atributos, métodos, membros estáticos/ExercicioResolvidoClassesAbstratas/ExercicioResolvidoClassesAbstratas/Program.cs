using ExercicioResolvidoClassesAbstratas.Entities;
using ExercicioResolvidoClassesAbstratas.Entities.Enums;
using System;
using System.Globalization;

namespace ExercicioResolvidoClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Shape #" + i + " data:");
                Console.Write("Rectangle or Circle? (r/c)? ");
                char Verificação = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red) : ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (Verificação == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(width, height, color));

                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Circle(radius, color));
                }


;            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
