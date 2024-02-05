using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database
{
    internal class Movie
    {
        public string name { get; }

        public string category { get; }

        public int runTime { get; }

        public int yearReleased { get; }

        public Movie(string _name, string _category, int _runTime, int _yearReleased)
        {
            name = _name;
            category = _category;
            runTime = _runTime;
            yearReleased = _yearReleased;
        }

        public void displayMovie()
        {
            Console.WriteLine(name);
            Console.WriteLine($"\t{runTime} minutes long");
            Console.WriteLine($"\tReleased in {yearReleased}");
            Console.WriteLine();
        }
    }
}
