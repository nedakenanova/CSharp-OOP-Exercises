namespace CO12_EmployeeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Ivan", 1200);
            Console.WriteLine(e.Work());
            Console.WriteLine(e);

            Manager m = new Manager("Maria", 2500, "HR");
            Console.WriteLine(m.Work());
            Console.WriteLine(m);

            Developer d = new Developer("Georgi", 3000, "C#");
            Console.WriteLine(d.Work());
            Console.WriteLine(d);
        }
    }
}
