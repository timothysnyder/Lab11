using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> Selection = new List<Movie>();

            Selection.Add(new Movie("Sci-Fi", "Terminator"));

            Selection.Add(new Movie("Sci-Fi", "Star Wars Episope IV: A New Hope"));

            Selection.Add(new Movie("Sci-Fi", "Millennium"));

            Selection.Add(new Movie("horror", "Friday the 13th"));

            Selection.Add(new Movie("horror", "Freddie vs Jason"));

            Selection.Add(new Movie("horror", "I Know What You Did Last Summer"));

            Selection.Add(new Movie("drama", "Shawshank Redemption"));

            Selection.Add(new Movie("drama", "Saving Private Ryan"));

            Selection.Add(new Movie("drama", "The Notebook"));

            Selection.Add(new Movie("animated", "Sponge Bob"));

            Selection.Add(new Movie("animated", "Toy Story"));

            Selection.Add(new Movie("animated", "Boss Babys"));

            Selection.Add(new Movie("romcom", "Forgetting Sarah Marshall"));

            Selection.Add(new Movie("romcom", "50 First Dates"));

            Selection.Add(new Movie("romcom", "Saving Silverman"));

            Console.WriteLine("\tWelcome to the movies list application!" +
                    "\n\n\tThere are 15 movie choices in this list.");
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine(" \nPlease Select a Category number 1-5 that you are you interested in?" +
                    "\n 1 = Sci-Fi, 2 = Horror, 3 = Drama, 4 = Animated, 5 = Romantic Comidies "); 
              
                string pick = Console.ReadLine();

                while (!Regex.IsMatch(pick, @"^[1-5]"))
                {
                    Console.WriteLine("invalid entry !! try again (Sci-Fi,horror,drama,animated,romcom) 1-5: ");

                    pick = Console.ReadLine();
                }
                int input = int.Parse(pick);
                if (input == 1)
                {
                    foreach (Movie item in Selection)
                    {
                        if (item.Catagory == "Sci-Fi")
                        {
                            item.PrintInfo();
                        }
                    }

                }
                else if (input == 2)
                {

                    foreach (Movie item in Selection)
                    {
                        if (item.Catagory == "horror")
                        {
                            item.PrintInfo();
                        }
                    }
                }
                else if (input == 3)
                {
                    foreach (Movie item in Selection)
                    {
                        if (item.Catagory == "drama")
                        {
                            item.PrintInfo();
                        }
                    }
                }
                else if (input == 4)
                {
                    foreach (Movie item in Selection)
                    {
                        if (item.Catagory == "animated")
                        {
                            item.PrintInfo();
                        }
                    }

                }
                else if (input == 5)
                {
                    foreach (Movie item in Selection)
                    {
                        if (item.Catagory == "romcom")
                        {
                            item.PrintInfo();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("invalid entry you dummie!!");
                }

                repeat = Confirmation("coninue (y/n)");
            }

        }

        public static bool Confirmation(string message)

        {

            Console.WriteLine(message);

            string googles = Console.ReadLine().ToLower();

            if (googles == "y")
            {
                return true;
            }
            else if (googles == "n")
            {
                return false;

                Console.WriteLine("thank you");
            }
            else
            {
                Console.WriteLine("invalid entry !! try again (y/n): ");
            }

            return Confirmation(message);
        }
    }
}
