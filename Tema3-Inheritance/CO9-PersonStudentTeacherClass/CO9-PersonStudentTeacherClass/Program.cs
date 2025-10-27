using System;
using System.Collections.Generic;

namespace CO9_PersonStudentTeacherClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person person = new Person("Ivan", "Petrov", 40);
            Student student = new Student("Maria", "Georgieva", 20, 5.75);
            Teacher teacher = new Teacher("Nikolay", "Dimitrov", 35, "Mathematics");

            
            List<Person> people = new List<Person> { person, student, teacher };

            
            foreach (var p in people)
            {
                Console.WriteLine(p);
            }
        }
    }
}
