using CO3_StudentClass;
using System;
class Program {
    static void Main(string[] args)
    {
        var s = new Student("Neda", "Kenanova", "neda@example.com");
        s.AddGrade(6.00);
        s.AddGrade(5.50);
        s.AddGrade(4.00);

        Console.WriteLine(s.FullName);                   // Neda Kenanova
        Console.WriteLine($"{s.GetAverageGrade():F2}");  // 5.17
        Console.WriteLine(s);                            // Student: Neda Kenanova, Email: neda@example.com, Avg: 5.17

        try
        {
            s.AddGrade(7.00); // грешка
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Грешка: " + ex.Message);
        }

    }
}
