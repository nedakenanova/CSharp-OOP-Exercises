using CO4_LibraryClass;
using System;
class Program
{
    static void Main()
    {
        var library = new Library();
        library.AddBook(new Book("Clean Code", "Robert C. Martin", 2008));
        library.AddBook(new Book("C# in Depth", "Jon Skeet", 2019));
        library.AddBook(new Book("Clean Architecture", "Robert C. Martin", 2017));

        Console.WriteLine("All:");
        foreach (var b in library.GetAllBooks()) Console.WriteLine(b);

        Console.WriteLine("\nBy author (Robert C. Martin):");
        foreach (var b in library.FindByAuthor("robert c. martin")) Console.WriteLine(b);

        Console.WriteLine("\nBy title keyword (clean):");
        foreach (var b in library.FindByTitle("clean")) Console.WriteLine(b);
    }
}
    
