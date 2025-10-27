using C015_AbstractShapeClass;
using System;
using System.Collections.Generic;

namespace CO15_AbstractShapeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle("Circle 1", 5),
                new Rectangle("Rectangle 1", 4, 6),
                new Triangle("Triangle 1", 3, 4, 5)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.Name}:");
                Console.WriteLine($"  Area: {shape.GetArea():F2}");
                Console.WriteLine($"  Perimeter: {shape.GetPerimeter():F2}");
                Console.WriteLine();
            }
        }
    }
}

