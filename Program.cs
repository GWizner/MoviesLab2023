using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;
using System.Reflection;

namespace MoviesLab2023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>() { new Movie("Dune", "Adventure"), new Movie("Dune", "Drama"), new Movie("Dune", "Sci-Fi"),
            new Movie("Interstellar 5555", "Adventure"), new Movie("Interstellar 5555", "Anime"), new Movie("Pulp Fiction", "Drama"),
            new Movie("Gummo", "Comedy"), new Movie("Gummo", "Drama"), new Movie("Spirited Away", "Adventure"),
            new Movie("Spirited Away", "Anime"), new Movie("Spirited Away", "Fantasy"), new Movie("Ju-on", "Horror"),
            new Movie("Evil Dead 2", "Comedy"), new Movie("Evil Dead 2", "Horror"), new Movie ("The Princess Bride", "Adventure"),
            new Movie ("The Princess Bride", "Fantasy"), new Movie ("The Princess Bride", "Romance"), new Movie("Army of Darkness", "Comedy"),
            new Movie("Army of Darkness", "Horror"), new Movie("Let the Right One In", "Drama"), new Movie("Let the Right One In", "Fantasy"),
            new Movie("Let the Right One In", "Horror"), new Movie("Let the Right One In", "Romance")};

            string y = "y";
            string yes = "yes";
            bool keepAsk = true;
            bool trueAns = false;

            Console.Write("Hello, User. ");
            while (keepAsk)
            {
                Console.WriteLine("Please select which genre of movie you'd like to see: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1)Adventure");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" 2)Anime");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" 3)Comedy");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(" 4)Drama");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(" 5)Fantasy");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write(" 6)Horror");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" 7)Romance");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" 8)Sci-Fi");
                Console.ResetColor();
                string userAnswer = Console.ReadLine().ToLower();
                Console.WriteLine();
                trueAns = int.TryParse(userAnswer, out int userAns);

                if (trueAns || movies.Any(x => x.category.Contains(userAnswer, StringComparison.CurrentCultureIgnoreCase)))
                {
                    MovieSearch.NewSearch(movies, userAnswer,userAns, trueAns);
                    keepAsk = false;
                }
                else
                {
                    Console.WriteLine("Sorry, we have nothing from that genre. Please try again");
                    Console.WriteLine();
                    keepAsk = true;
                }
                Console.WriteLine("\nWould you like to see any more (y/n)? ");
                string more = Console.ReadLine().ToLower();
                more.Trim();
                more = more.Trim();
                Console.WriteLine();

                if (more == y || more == yes)
                {
                    keepAsk = true;
                }
                else
                {
                    keepAsk = false;
                }
            }
        }
    }
}