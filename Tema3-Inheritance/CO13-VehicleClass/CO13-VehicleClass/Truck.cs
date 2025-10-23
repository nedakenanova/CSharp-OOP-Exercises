using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO13_VehicleClass
{
    internal class Truck:Vehicle
    {
        public double LoadCapacity {  get; set; }
        public Truck(string brand,string model,int year,double capacity) : base(brand, model, year)
        {
            if(capacity<0) throw new ArgumentException("Capacity cannot be under null",nameof(capacity));
            LoadCapacity = capacity;
        }
        public override string Start()
        {
            return "The truck is starting";
        }
        public override string ToString()
        {
            return base.ToString() + $" Capacity is {LoadCapacity}";
            
        }
    }
}
