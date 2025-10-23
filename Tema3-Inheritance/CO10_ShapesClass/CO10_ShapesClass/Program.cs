using System;

namespace CO10_ShapesClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle("Circle1", 5);
            Shape rect = new Rectangle("Rect1", 4, 6);

            Console.WriteLine($"{circle.Name} - Area: {circle.GetArea():F2}, Perimeter: {circle.GetPerimeter():F2}");
            Console.WriteLine($"{rect.Name}   - Area: {rect.GetArea():F2}, Perimeter: {rect.GetPerimeter():F2}");

            Console.ReadKey(); 
        }
    }
}
