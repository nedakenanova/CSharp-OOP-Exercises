using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C011_Animal
{
    internal class Dog:Animal
    {
        public string Breed {  get; set; }
        public Dog(string name,int age,string breed) : base(name, age)
        {
            if (string.IsNullOrEmpty(breed))
                throw new ArgumentNullException(nameof(breed), "Breed cannot be null");

            this.Breed = breed;
        }
        public override string MakeSound()
        {
            return "Woof!";
        }
    }
}
