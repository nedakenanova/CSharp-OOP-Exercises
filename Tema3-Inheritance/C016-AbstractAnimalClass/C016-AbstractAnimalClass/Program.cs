using C016_AbstractAnimalClass;
using System;
using System.Collections.Generic;

namespace CO16_AbstractAnimalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Rex", 4, "German Shepherd"),
                new Cat("Mimi", 2, "White"),
                new Bird("Coco", 1, 0.35)
            };

            
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
              animal.MakeSound();
               animal.Move();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
