using System;
using System.Collections.Generic;
using System.Text;

namespace Pamoka5_object_programavimas
{
    internal class Book
    {
        public string Title { get; set; }  
        public string Author { get; set; }
        public int Years { get; set; }
        public Book(string title, string author, int years) {
        Title = title;
        Author = author;   
        Years = years;
        }
    }
}
