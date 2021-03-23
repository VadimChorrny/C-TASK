using Array_;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    class CoverBook
    {
        public String Name { get; set; }
        public String Author { get; set; }
        public String Year { get; set; }
        public CoverBook(String name, String author, String year)
        {
            this.Name = name;
            this.Author = author;
            this.Year = year;
        }
        public static implicit operator Book(CoverBook book)
        {
            return new Book(book.Author, null,book.Name,book.Year) ;
        }
        public override string ToString()
        {
            return $"----COVERBOOK----\n" +
                $"Name book : {Name}\n" +
                $"Author : {Author}\n" +
                $"Year manufacture : {Year}";
        }
    }
}
