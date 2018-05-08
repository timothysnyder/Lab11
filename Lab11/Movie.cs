using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
  
        //Properties

        public string Name { get; set; }

        public string Catagory { get; set; }

        // constructor

        public Movie()

        {



        }



        //

        public Movie(string Catagories, string Titles)

        {
            Catagory = Catagories;

            Name = Titles;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name);
        }
    }
}
