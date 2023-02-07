using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    struct Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Title = {Title},  Author = {Author}");
        }
    }
}
