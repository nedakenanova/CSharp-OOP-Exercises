using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO9_PersonStudentTeacherClass
{
    internal class Student:Person
    {
        public double Grade {  get; set; }
        public Student(string firstName, string lastName, int age, double grade)
             : base(firstName, lastName, age)   
        {
            Grade = grade;
        }

        public override string ToString()
        {
            return $"Student: {FirstName} {LastName}, Age: {Age}, Grade: {Grade:f2}";
        }
    }
}
