using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C011_Animal
{
    internal class Cat:Animal
    {
        public string Color {  get; set; }
        public Cat(string name,int age,string color) : base(name, age)
        {
            if (string.IsNullOrEmpty(color))
            {
                throw new ArgumentNullException(nameof(color),"Color cannot be null");
            }
            this.Color = color;
        }
        public override string MakeSound()
        {
            return "Meow!";
        }
    }
}
