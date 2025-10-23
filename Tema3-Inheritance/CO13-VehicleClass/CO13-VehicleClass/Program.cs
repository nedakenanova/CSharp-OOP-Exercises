using System;
using System.Collections.Generic;

namespace CO13_VehicleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Vehicle vehicle = new Vehicle("Generic", "Transport", 2000);
            Car car = new Car("Toyota", "Corolla", 2020, 4);
            Truck truck = new Truck("Volvo", "FH", 2018, 18000);

            
            Console.WriteLine(vehicle.Start());
            Console.WriteLine(car.Start());
            Console.WriteLine(truck.Start());

            Console.WriteLine();

            
            Console.WriteLine(vehicle);
            Console.WriteLine(car);
            Console.WriteLine(truck);

            Console.WriteLine();

            
            List<Vehicle> vehicles = new List<Vehicle> { vehicle, car, truck };

            foreach (var v in vehicles)
            {
                Console.WriteLine($"{v.GetType().Name}: {v.Start()}");
            }
        }
    }
}
