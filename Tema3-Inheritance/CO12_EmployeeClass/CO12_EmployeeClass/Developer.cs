using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO12_EmployeeClass
{
    internal class Developer:Employee
    {
        public string ProgrammingLanguage {  get; set; }
        public override string Work()
        {
            return $"Developer is coding in {ProgrammingLanguage}";
        }
        public Developer(string name,double salary,string pl) : base(name, salary)
        {
            if (string.IsNullOrEmpty(pl))
            {
                throw new ArgumentNullException(nameof(pl), "Languauge cannot be null");
            }
            this.ProgrammingLanguage = pl ;
        }
        public override string ToString()
        {
            return $"{Name} is a developer coding in {ProgrammingLanguage}, salary {Salary} lv.";
        }


    }
}
