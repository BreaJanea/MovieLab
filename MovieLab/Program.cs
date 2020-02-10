using System;
using System.Collections.Generic;

namespace MovieLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List Application!\n" +
                            "There are 10 movies in this list.\n");

            List<Movie> MovieList = new List<Movie>();
            MovieList.Add(new Movie("Mean Girls", "Comedy"));
            MovieList.Add(new Movie("The Devil Wears Prada", "Comedy"));
            MovieList.Add(new Movie("Bring It On", "Comedy"));
            MovieList.Add(new Movie("It", "Horror"));
            MovieList.Add(new Movie("Queen & Slim", "Drama"));
            MovieList.Add(new Movie("Malibus Most Wanted", "Comedy"));
            MovieList.Add(new Movie("Frozen", "Animated"));
            MovieList.Add(new Movie("Jaws", "Horror"));
            MovieList.Add(new Movie("Mulan", "Animated"));
            MovieList.Add(new Movie("The Lion King", "Animated"));

            do
            {
                Console.Write("\nWhat category are you interested in? (Comedy, Drama, Horror, or Animated?)  ");
                string input = Console.ReadLine();

                foreach (Movie m in MovieList)
                {
                    if (m.Category.Contains(input))
                    {
                        Console.WriteLine(m);
                    }
                }
            } while (UserContiue());
        }
        public static bool UserContiue()
        {
            char c;
            do
            { 
                Console.Write("\nContinue? (y/n)?\n");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    Console.WriteLine("\nSee ya!");
                    return false;
                }
            } while (c != 'y' && c != 'Y');
            return true;

           
        }
    }
}
