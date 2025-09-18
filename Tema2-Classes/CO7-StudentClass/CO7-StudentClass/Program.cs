using CO7_StudentClass;
using System;
class Program
{
    static void  Main()
    {
        var school = new School();
        school.AddStudent(new Student("Ivan", "Petrov", 5.50));
        school.AddStudent(new Student("Maria", "Ivanova", 6.00));
        school.AddStudent(new Student("Georgi", "Dimitrov", 4.20));

        Console.WriteLine(school);
        // School has 3 students. Average grade: 5.23

        Console.WriteLine("Top student:");
        foreach (var s in school.GetTopStudents(1))
            Console.WriteLine(s);
        // Student: Maria Ivanova, Grade = 6.00

        Console.WriteLine("Search 'ivan':");
        foreach (var s in school.FindStudent("ivan"))
            Console.WriteLine(s);
        // Student: Maria Ivanova, Grade = 6.00
    }
}