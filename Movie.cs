using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesLab2023
{
    public class Movie
    {

        public string title;
        public string category;

        public Movie(string newTitle, string newCategory)
        {
            title = newTitle;
            category = newCategory;
        }
    }
    public class MovieSearch
    {
        public static void NewSearch(List<Movie> movies, string userAnswer, int userInt, bool trueAns)
        {
            Dictionary<int, string> movieCategory = new();
            movieCategory[1] = "adventure";
            movieCategory[2] = "anime";
            movieCategory[3] = "comedy";
            movieCategory[4] = "drama";
            movieCategory[5] = "fantasy";
            movieCategory[6] = "horror";
            movieCategory[7] = "romance";
            movieCategory[8] = "sci-fi";

            int key = movieCategory.FirstOrDefault(x => x.Value == userAnswer).Key - 1;

            if (trueAns)
            {
                string thisCategory = movieCategory[userInt];

                foreach (var movieTitle in movies)
                {
                    if (movieTitle.category.Equals(thisCategory, StringComparison.CurrentCultureIgnoreCase))
                    {
                        GetColor.CategoryColor(userInt - 1);
                        Console.WriteLine(movieTitle.title);
                    }
                }
                Console.ResetColor();
            }
            else if (!trueAns)
            {
                foreach (Movie catSearch in movies)
                {
                    if (catSearch.category.Contains(userAnswer, StringComparison.CurrentCultureIgnoreCase))
                    {
                        GetColor.CategoryColor(key);
                        Console.WriteLine($"{catSearch.title}");
                    }
                }
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("No good.");
            }
        }
    }
}
