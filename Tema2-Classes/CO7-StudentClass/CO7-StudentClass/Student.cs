using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO7_StudentClass
{
    internal class Student
    {
        private string _firstName = "";
        private string _lastName = "";
        private double _grade;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("First name cannot be empty.");
                _firstName = value.Trim();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Last name cannot be empty.");
                _lastName = value.Trim();
            }
        }

        public double Grade
        {
            get => _grade;
            set
            {
                if (value < 2.00 || value > 6.00)
                    throw new ArgumentOutOfRangeException(nameof(Grade), "Grade must be between 2.00 and 6.00.");
                _grade = value;
            }
        }

        public string FullName => $"{FirstName} {LastName}";

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;  
            LastName = lastName;
            Grade = grade;
        }

        public override string ToString() => $"Student: {FullName}, Grade = {Grade:F2}";
    }
}

