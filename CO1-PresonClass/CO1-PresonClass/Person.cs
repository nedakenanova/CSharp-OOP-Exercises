using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO1_PresonClass
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Името не може да е празно или само интервали.");
            if (age < 0 || age > 120)
                throw new ArgumentOutOfRangeException("Възрастта трябва да е между 0 и 120");

            this.Name = name;
            this.Age = age;
        }
        public string Introduce() => $"Здравей, аз съм {Name} и съм на {Age} години.";
    }
}
