using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CO13_VehicleClass
{
    internal class Car:Vehicle
    {
        public int NumberOfDoors {  get; set; }
        public Car(string brand,string model,int year,int doors) : base(brand, model, year)
        {
            if (doors < 0) throw new ArgumentException("Doors cannot be under 0", nameof(doors));

            NumberOfDoors = doors;
        }
        public override string Start()
        {
            return "The car is starting";
        }
        public override string ToString()
        {
            return $"{Brand} {Model}, Year: {Year}, Doors: {NumberOfDoors}";
        }

    }
}
