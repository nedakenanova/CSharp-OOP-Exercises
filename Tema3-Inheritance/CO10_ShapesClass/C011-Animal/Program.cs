using System;
using System.Collections.Generic;

namespace C011_Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Animal("Generic", 5),
                new Dog("Rex", 3, "Labrador"),
                new Cat("Mimi", 2, "White")
            };

            foreach (var a in animals)
            {
                Console.WriteLine($"{a.Name} ({a.GetType().Name}): {a.MakeSound()}");
            }
        }
    }
}
