using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C016_AbstractAnimalClass
{
    internal class Bird:Animal
    {
        public double WingSpan {  get; set; }
        
        public Bird(string name, int age, double w) : base(name, age)
        {
            if (w < 0) throw new ArgumentException("Novalid for wing span");
           WingSpan = w;
        }
        public override void MakeSound()
        {
            Console.WriteLine("chrr");
        }
        public override void Move()
        {
            Console.WriteLine("flying");
        }
        public override string ToString()
        {
            return base.ToString() + $"Wing span is {WingSpan}";
        }
    }
}
