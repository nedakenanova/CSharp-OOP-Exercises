using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C016_AbstractAnimalClass
{
    internal class Dog:Animal
    {
        public string Breed {  get; set; }
        public Dog(string name,int age,string B) : base(name, age)
        {
            if(string.IsNullOrEmpty(B)) throw new ArgumentNullException("Novalid argument for breed",nameof(B));
            this.Breed = B;
        }
        public override void MakeSound()
        {
            Console.WriteLine("bay");
        }
        public override void Move()
        {
            Console.WriteLine("Running");
        }
        public override string ToString()
        {
            return base.ToString() + $"Breed is {Breed}";
        }
    }
}
