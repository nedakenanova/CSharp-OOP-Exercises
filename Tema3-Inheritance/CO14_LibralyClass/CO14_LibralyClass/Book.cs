using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO14_LibralyClass
{
    internal class Book
    {
        public string Title {  get; set; }
        public string Author {  get; set; }
        public int Year {  get; set; }
        public Book(string title, string author, int year)
        {
            if(string.IsNullOrEmpty(title))throw new ArgumentNullException(nameof(title),"Title is null");
            if (string.IsNullOrEmpty(author)) throw new ArgumentNullException(nameof(author), "Author is null");
            if (year < 0) throw new ArgumentOutOfRangeException("Year is under null", nameof(year));
            Title = title;
            Author = author;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Title} by {Author}, Year:{Year}";
        }
    }
}
