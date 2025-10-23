using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C011_Animal
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age {  get; set; }
        public Animal(string name,int age)
        {
            if (string.IsNullOrEmpty(name)) {  throw new ArgumentNullException("Name cannot be null",nameof(name)); }
            if (age < 0) { throw new ArgumentOutOfRangeException("Age cannot be smaller than 0", nameof(age)); }
            Name = name;
            Age = age;
        }
        public virtual string MakeSound()
        {
            return "Some generic animal sound";
        }
    }
}
