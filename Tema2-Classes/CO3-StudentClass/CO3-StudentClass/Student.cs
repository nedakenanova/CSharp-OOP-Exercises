using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO3_StudentClass
{
    internal class Student
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Email {  get; set; }
        public List<double> Grades { get; private set; }

        public Student(string firstName, string lastName, string email)
        {
            FirstName = firstName;  
            LastName = lastName;
            Email = email;
            Grades = new List<double>();

        }
        public void AddGrade(double grade)
        {
            if(grade<=0 || grade > 6.00)
            {
                throw new ArgumentOutOfRangeException("Not valid grade");
            }
            else
            {
                this.Grades.Add(grade);
            }
        }
        public double GetAverageGrade()
        {
            if (Grades.Count == 0) return 0.0;
            return Grades.Average();
        }

        public string FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"Student {FullName},Email {this.Email}, Avg {GetAverageGrade():f2}";
        }
    }
}
