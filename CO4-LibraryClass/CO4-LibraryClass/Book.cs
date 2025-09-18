using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CO4_LibraryClass
{
    internal class Book
    {
       public string Title { get; }
        public string Author {  get;}
        public int Year {  get;}
        public Book(string title, string author,int year)
        {
            if (string.IsNullOrEmpty(title))
            {
               throw new ArgumentNullException("Title is null");
                
            }
            if(string.IsNullOrEmpty(author)) 
            {
                throw new ArgumentNullException("Author is null");

            }
            if (year <= 0)
                throw new ArgumentOutOfRangeException(nameof(year), "Year must be greater than 0");
            this.Title = title;
                this.Author = author;
            this.Year = year;
           
        }
        public override string ToString()
        {
            return $"{Title} by {Author} ({Year})";
        }

    }
}
