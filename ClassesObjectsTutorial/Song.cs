using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsTutorial
{
    internal class Song
    {
        public string name, artist;
        public int sales;
        public static int songCount = 0;
        public Song(string Naam, string Artist, int Sales)
        {
            name = Naam;
            artist = Artist;
            sales = Sales;
            songCount++;
        }
        public Song()
        {
            name = "undefined";
            artist = "undefined";
            sales = 0;
        }
        public void Afbeelden()
        {
            Console.WriteLine("Nieuw liedje:");
            Console.WriteLine($"Naam: {name}");
            Console.WriteLine($"Artiest: {artist}");
            Console.WriteLine($"Aantal verkocht: {sales}");
            Console.WriteLine("-------------------------");
        }
    }
}
