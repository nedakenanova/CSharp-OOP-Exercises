using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CO14_LibralyClass
{
    internal class Libraly
    {
        public string Name {  get; set; }
        public List<Book> Books;
        public Libraly(string name, List<Book> books)
        {
            if (books == null) throw new ArgumentNullException("List is empty");
            if(string.IsNullOrEmpty(name)) throw new ArgumentNullException("Name is null",nameof(name));
            Name = name;
            Books = books;
        }
        public void AddBook(Book book)
        {
            for(int i=0; i<Books.Count; i++)
            {
                if (Books[i].Title == book.Title) throw new Exception("The book exists");
                else Books.Add(book);
            }
            
            
        }
        public void RemoveBook(Book book) {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title == book.Title) Books.Remove(book);
                else throw new Exception("there is no book with this title here");
            }
        }
        public void FindBook(Book book)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title == book.Title)
                {
                    Console.WriteLine(Books[i].ToString());
                }
                
            }
        }
        L
    }
}
