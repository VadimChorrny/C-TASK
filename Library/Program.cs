﻿using System;

namespace Array_
{

    // Book
    class Book
    {
        public String Author { get; set; }
        String Cypher { get; set; }
        public String Name { get; set; }
        String CreateYear { get; set; }
        public Book(String author, String cypher, String name, String year)
        {
            this.Author = author;
            this.Cypher = cypher;
            this.Name = name;
            this.CreateYear = year;
        }
        public void print()
        {
            Console.WriteLine(Author);
            Console.WriteLine(Cypher);
            Console.WriteLine(Name);
            Console.WriteLine(CreateYear);
        }
    }

    class Library
    {
        private Book[] book;
        public Library() { book = new Book[0]; } // start init
        public void AddBook(Book books)
        {
            if (book == null)
            {
                return;
            }
            Array.Resize(ref book, book.Length + 1);
            book[book.Length - 1] = books;
        }
        public void RemoveBook(Book books)
        {
            Array.Resize(ref book, book.Length - 1);
        }
        public void SortByAuthor()
        {
            Array.Sort(book, (e, e1) => String.Compare(e.Author, e1.Author));
        }
        public void SortByAuthorByName()
        {
            SortByAuthor();
            Array.Sort(book, (e, e1) => String.Compare(e.Name, e1.Name));
        }

        public void SearchName(String Name)
        {
            int show = Array.FindIndex(book, (e) => e.Name == Name);
            book[show].print();
        }
        public void SearchAuthor(String Author)
        {
            int show = Array.FindIndex(book, (e) => e.Author == Author);
            book[show].print();
        }
        public void Render()
        {
            foreach (Book item in book)
            {
                if (book.Length > 0)
                {
                    item.print();
                    Console.WriteLine("***************");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Library lib = new Library();
            Book book = new Book("Shildt", "C#", "Arial Middle", "01.07.2020");
            Book book1 = new Book("Robert Martin", "Arial", "Clean Code", "03.09.2012");
            Book book2 = new Book("Jeffrey Richter", "New Times Roman", "CLR via C#", "21.02.2021");
            Book book3 = new Book("Josepth Albahari", "Kursiv", "C# 7.0 in a Nutshell", "07.07.2010");
            Book book4 = new Book("Bjarne Stroustrup", "Full Arrial", "A Tour of C++", "15.11.2005");

            lib.AddBook(book);
            lib.AddBook(book1);
            lib.AddBook(book2);
            lib.AddBook(book3);
            lib.AddBook(book4);

            lib.Render();

            lib.RemoveBook(book1);

            lib.Render();

            Console.WriteLine("-------SEARCH--------");
            lib.SearchAuthor("Josepth Albahari");
            lib.SearchName("CLR via C#");
            Console.WriteLine("--------SORTING--------");
            lib.SortByAuthor();
            lib.Render();
            Console.WriteLine("-----------------------");
            lib.SortByAuthorByName();
            lib.Render();





            //Console.WriteLine("Test");
            //// 7
            //int[] arr = { 1, -2, -3, 4, 5, -6, 1 - 1 };

            //int[] arr1 = Array.FindAll(arr, (e) => { return e < 0; });
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine($"Number : {arr1[i]}");
            //}
            //// analog method
            //int[] arr2 = Array.FindAll(arr, (e) => { return e >= 0; });
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine($"Number pluser : {arr2[i]}");
            //}

            //// 10

            //int[] price = { 1, 2, 3, 4 };
            //String[] product = { "Ice", "Milk", "Water", "Cola" };
            //Array.Sort(price, product);

            //int[] arr = new int [10];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            //arr[5] = 6;
            //arr[6] = 7;
            //arr[7] = 8;
            //arr[8] = 9;
            //arr[9] = 10;

            //Array.Resize(ref arr, arr.Length - 1);

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
        }

    }
}
