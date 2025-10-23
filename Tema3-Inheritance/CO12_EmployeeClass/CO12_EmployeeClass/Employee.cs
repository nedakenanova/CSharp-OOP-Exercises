using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO12_EmployeeClass
{
    internal class Employee
    {
        public string Name { get; set; }
        public double Salary {  get; set; }
        public Employee(string name,double salary) 
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Name cannot be null");

            }
            if (salary < 0)
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary cannot be negative");

            this.Name = name;
            this.Salary = salary;
        }
        public virtual string  Work()
        {
            return $"Employee is working";
        }
        public override string ToString() 
        {
            return $"{this.Name} take {this.Salary:F2} lv.";
        }
    }
}
