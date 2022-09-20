using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjectsTutorial
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;
        public Student(string Name, string Major, double GPA)
        {
            name = Name;
            major = Major;
            gpa = GPA;
        }
        public Student()
        {
            name = "undefined";
            major = "undefined";
            gpa = 0;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

        public void Afbeelden()
        {
            Console.WriteLine("Nieuwe student:");
            Console.WriteLine($"Voornaam: {name}");
            Console.WriteLine($"Studierichting: {major}");
            Console.WriteLine($"Gemiddelde score: {gpa}");
            Console.WriteLine($"Student is geslaagd: {HasHonors()}");
            Console.WriteLine("-------------------------");
        }
    }
}
