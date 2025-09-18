using System;

namespace CO8_UniversityClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var uni = new University("Tech University");

           
            var f1 = new Faculty("Computer Science");
            var f2 = new Faculty("Mathematics");
            uni.AddFaculty(f1);
            uni.AddFaculty(f2);

            
            var c1 = new Course("CS101", "Intro to Programming", 6);
            var c2 = new Course("CS102", "Data Structures", 5);
            f1.AddCourse(c1);
            f1.AddCourse(c2);

            
            var s1 = new Student(1, "Maria", "Ivanova", "maria@uni.bg");
            var s2 = new Student(2, "Ivan", "Petrov", "ivan@uni.bg");
            uni.AddStudent(s1);
            uni.AddStudent(s2);

           
            Console.WriteLine("Students with 'Ivan':");
            foreach (var st in uni.FindStudents("Ivan"))
            {
                Console.WriteLine(st);
            }

     
            Console.WriteLine();
            Console.WriteLine(uni);

           
            Console.WriteLine("\nFaculties:");
            foreach (var fac in uni.Faculties)
            {
                Console.WriteLine(fac);
                foreach (var course in fac.Courses)
                {
                    Console.WriteLine("   " + course);
                }
            }
        }
    }
}
