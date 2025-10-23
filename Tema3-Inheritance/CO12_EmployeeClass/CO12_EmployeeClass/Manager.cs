using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO12_EmployeeClass
{
    internal class Manager:Employee
    {
        public string Department {  get; set; }
        public override string Work()
        {
            return $"Manager is managing department {Department}";
        }
        public Manager(string name, double salary, string department)
       : base(name, salary)  
        {
            if (string.IsNullOrWhiteSpace(department))
                throw new ArgumentNullException(nameof(department), "Department cannot be null or empty");

            Department = department;
        }
        public override string ToString()
        {
            return $"{Name} works as a manager of {Department} department with salary {Salary} lv.";
        }

    }
}
