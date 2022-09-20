using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsTutorial
{
    internal class Movie
    {
        public string name, director;
        private string rating;

        public Movie(string Name, string Director, string rating)
        {
            name = Name;
            director = Director;
            Rating = rating;
        }
        public Movie()
        {
            name = "undefined";
            director = "unknown";
            rating = "unset";
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

        public void Afbeelden()
        {
            Console.WriteLine("Nieuwe film:");
            Console.WriteLine($"Naam: {name}");
            Console.WriteLine($"Director: {director}");
            Console.WriteLine($"Rating: {rating}");
            Console.WriteLine("-------------------------");
        }
    }
}
