using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO9_PersonStudentTeacherClass
{
    internal class Teacher:Person
    {
        public string Subject {  get; set; }
        public Teacher(string firstName, string lastName, int age, string subject) : base(firstName, lastName, age)
        {

            if (string.IsNullOrWhiteSpace(subject))
                throw new ArgumentException("Subject cannot be null or empty", nameof(subject));
            Subject = subject;

        }
        public override string ToString()
        {
            return $"Teacher: {FirstName} {LastName}, Age: {Age}, Subject: {Subject}";
        }
    }
}
