using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C016_AbstractAnimalClass
{
    internal abstract class Animal
    {
        public string name {  get; set; }
        public int Age {  get; set; }
        public Animal(string name,int age)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name is null");
            if (age < 0) throw new ArgumentOutOfRangeException("Nevalid age");
            this.name = name;
            this.Age = age;
        }
        public abstract void  MakeSound();
        public abstract void Move();
        public override string ToString()
        {
            return $"{this.name}, {this.Age} years old.";
        }

    }
}
