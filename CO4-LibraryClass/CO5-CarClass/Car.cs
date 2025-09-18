using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO5_CarClass
{
    internal class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public double FuelCapacity { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public Car(string make,string model,double fuelCapacity,double fuelConsumption)
        {
            if(string.IsNullOrWhiteSpace(make)) throw new ArgumentNullException("make is null");
            if(string.IsNullOrWhiteSpace(model)) throw new ArgumentNullException("model is null");
            if (fuelCapacity <= 0) throw new ArgumentOutOfRangeException("fuelCapacity cannot be smaller than 0");
           
            if (fuelConsumption <= 0) throw new ArgumentOutOfRangeException("fuelConsumption cannot be smaller than 0");
            Make = make; 
            Model = model;
            FuelCapacity = fuelCapacity;
            FuelAmount = 0;
            FuelConsumption = fuelConsumption;


        }
        public void Refuel(double liters)
        {
            if (liters <= 0)
                throw new ArgumentOutOfRangeException(nameof(liters), "Liters must be > 0");

            FuelAmount += liters;
            if (FuelAmount > FuelCapacity)
                FuelAmount = FuelCapacity; 
        }

        public void Drive(double distance)
        {
            if (distance <= 0)
                throw new ArgumentOutOfRangeException(nameof(distance), "Distance must be > 0");

            double neededFuel = (distance / 100) * FuelConsumption;
            if (neededFuel > FuelAmount)
                throw new InvalidOperationException("Not enough fuel");

            FuelAmount -= neededFuel;
        }

        public override string ToString()
        {
            return $"Car: {Make} {Model}, Fuel: {FuelAmount:f2}/{FuelCapacity} L";
        }
    }
}
