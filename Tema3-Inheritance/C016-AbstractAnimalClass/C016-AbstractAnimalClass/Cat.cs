using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C016_AbstractAnimalClass
{
    internal class Cat:Animal
    {
        public string Color {  get; set; }
        public Cat(string name,int age,string color) : base(name, age)
        {
            if(string.IsNullOrEmpty(color)) throw new ArgumentNullException("Novalid argument for color");
            Color = color;
        }
        public override void MakeSound()
        {
            Console.WriteLine("mye ");
        }
        public override void Move()
        {
            Console.WriteLine("crawling");
        }
        public override string ToString() {
            return base.ToString() + $"Color is {Color}";
        }
    }
}
