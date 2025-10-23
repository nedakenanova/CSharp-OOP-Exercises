using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO9_PersonStudentTeacherClass
{
    internal class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Person(string firstName, string lastName, int age)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentNullException("FirstName is null");
            }
            if (string.IsNullOrEmpty(lastName)) { throw new ArgumentNullException("Last name is null"); }
            if (age < 0) { throw new ArgumentOutOfRangeException("Age is under 0"); }
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }
        public override string ToString() { return $"Person: {FirstName} {LastName}, Age: {Age}"; }
    }
}
