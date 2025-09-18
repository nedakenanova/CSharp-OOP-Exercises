using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO4_LibraryClass
{
    internal class Library
    {
        private readonly List<Book> _books = new();
        public IReadOnlyList<Book> Books => _books.AsReadOnly();
        public void AddBook(Book book)
        {
            if (book == null) throw new ArgumentNullException("Book is null");
            else _books.Add(book);
        }
        public IEnumerable<Book> FindByAuthor(string author)
        {
            var books = new List<Book>();
            foreach (Book book in _books)
            {
                if (string.Equals(book.Author, author, StringComparison.OrdinalIgnoreCase))

                {
                    books.Add(book);
                }
            }
            return books;
        }
      public  IEnumerable<Book> FindByTitle(string keyword)
      {
            var books = new List<Book>();
            foreach (Book book in _books)
            {
                if (book.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    books.Add(book);
                }

            }
            return books;

      }
        public IReadOnlyList<Book> GetAllBooks()
        {
            return _books.AsReadOnly();
        }


    }
}
