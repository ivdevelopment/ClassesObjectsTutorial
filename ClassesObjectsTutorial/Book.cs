using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsTutorial
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book()
        {
            title = "undefined";
            author = "unknown";
            pages = 0;
        }
        public Book(string Title, string Author, int Pages)
        {
            title = Title;
            author = Author;
            pages = Pages;
        }
        public void Afbeelden()
        {
            Console.WriteLine($"Titel: {title}");
            Console.WriteLine($"Auteur: {author}");
            Console.WriteLine($"Paginas: {pages}");
            Console.WriteLine("--------------");
        }

    }
}
