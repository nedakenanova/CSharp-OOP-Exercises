using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO13_VehicleClass
{
    internal class Vehicle
    {
        public string Brand {  get; set; }
        public string Model {  get; set; }
        public int Year {  get; set; }
        public Vehicle(string brand, string modeel, int year)
        {
            if(string.IsNullOrEmpty(brand)) throw new ArgumentNullException(nameof(brand),"Brand cannot be null");
            if (string.IsNullOrEmpty(modeel)) throw new ArgumentNullException(nameof(modeel), "Model cannot be null");
            if (year < 0) throw new ArgumentOutOfRangeException(nameof(year), "Year cannot be under null");
            this.Brand = brand;
            this.Model = modeel;
            this.Year = year;
        }
        public virtual string Start()
        {
            return "The vehicle is starting";
        }
        public override string ToString()
        {
            return $"{Brand} {Model}, Year: {Year}";
        }
    }
}
