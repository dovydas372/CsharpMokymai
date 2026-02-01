using System;
using System.Collections.Generic;

namespace Objektai__list_advance_7.ND._2_Pirmasis_elementas
{
    internal class Article
    {
        public string Title { get; set; }
        public string FullText { get; set; }

        public Article(string title, string text) 
        {
            Title = title;
            FullText = text;
        }
    }
}
