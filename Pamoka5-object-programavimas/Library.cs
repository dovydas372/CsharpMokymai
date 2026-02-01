using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace Pamoka5_object_programavimas
{
    internal class Library
    {
        public List<Book> Books { get; private set; }



        public Library()
        {
            Books = new List<Book> { }; 
        }


        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public List<Book> SearchByAuthor(string author)
        {
            List<Book> searchList = Books.Where(book => book.Author == author).ToList();
            //foreach (Book book in searchList)
            //{
            //    Console.WriteLine($"author: {book.Author} title: {book.Title} year: {book.Years}");
         
            //}

            return searchList;
        }


    }
}
