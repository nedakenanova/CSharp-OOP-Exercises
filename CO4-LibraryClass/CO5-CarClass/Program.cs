using CO5_CarClass;
using System;
class Program {
    static void Main(string[] args) 
    {
        var car = new Car("Toyota", "Corolla", 50, 5.5);

        car.Refuel(20);
        Console.WriteLine(car); 

        car.Drive(100);
        Console.WriteLine(car); 

        car.Drive(500);
    }
}
