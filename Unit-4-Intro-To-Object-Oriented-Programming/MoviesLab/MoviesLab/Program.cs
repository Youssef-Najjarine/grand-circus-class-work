using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace MoviesLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>() { 
                new Movie("John Wick", "Action", 2014, 101),
                new Movie("The Matrix", "Sci-Fi", 1999, 136),
                new Movie("The Godfather", "Drama", 1972, 175),
                new Movie("The Dark Knight", "Superhero", 2008, 152),
                new Movie("Oppenheimer", "Historical Drama", 2023, 180),
                new Movie("Spider-Man", "Superhero", 2002, 121),
                new Movie("The Shawshank Redemption", "Drama", 1994, 142),
                new Movie("Mission: Impossible", "Spy Thriller", 1996, 110),
                new Movie("Inception", "Sci-Fi", 2010, 148),
                new Movie("The Lord of the Rings", "Fantasy", 2001, 178),
                new Movie("The Avengers", "Superhero", 2012, 143),
                new Movie("Jurassic Park", "Sci-Fi", 1993, 127),
                new Movie("Pulp Fiction", "Crime", 1994, 154),
                new Movie("Forrest Gump", "Drama", 1994, 142),
                new Movie("The Lion King", "Animation", 1994, 88)
            };
            bool continueGame = false;
            List<Movie> filteredCategories = movies.OrderBy(movie => movie.Category).DistinctBy(movie => movie.Category).ToList();

            Console.WriteLine("Welcome to the Movie List Application!\n");
            Console.WriteLine($"There are {movies.Count} movies in this list.");
            do
            {
                string userInput = GetValidResponse(filteredCategories);
                int index = -1;
                bool numberEntered = Int32.TryParse(userInput, out index);
                List<Movie> filteredMovies;
                if (numberEntered)
                {
                    string category = "";
                    for (int i = 0; i < filteredCategories.Count; i++)
                    {
                        if (index == i + 1)
                        {
                            category = filteredCategories[i].Category;
                            break;
                        }
                    }
                    filteredMovies =
                      movies
                        .Where(movie => movie.Category == category)

                        .OrderBy(movie => movie.Title)
                        .ToList();
                } else
                {
                    filteredMovies =
                      movies
                        .Where(movie => movie.Category.ToLower().Trim() == userInput)
                        .OrderBy(movie => movie.Title)
                        .ToList();
                }
                PrintMovies(filteredMovies);
                continueGame = ContinueGame();
            } while (continueGame);
        }
        private static void PrintCategories(List<Movie> movies)
        {
            Console.WriteLine("\nCategories:");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"| {"#"} | {"Category",-16}|");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"| {i + 1} | {movies[i].Category,-16}|");
            }

            Console.WriteLine("-----------------------");
        }
        private static void PrintMovies(List<Movie> movies)
        {
            Console.WriteLine("\nMovies:");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"| {"Name",-25} | {"Category",-16} | {"Year",-2} | {"Run Time",-7}|");
            Console.WriteLine("-----------------------------------------------------------------");

            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"| {movies[i].Title,-25} | {movies[i].Category,-16} | {movies[i].YearReleased,2} | {movies[i].RunTime + " min",-7} |");
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }
        private static string GetValidResponse(List<Movie>  possibleAnswers)
        {
            string userInput;
            bool validAnswer = false;
            int index = -1;
            bool vallidIndex;
            do
            {
                PrintCategories(possibleAnswers);
                Console.Write("\nWhat category are you interested in? ");
                userInput = Console.ReadLine().ToLower().Trim();
                vallidIndex = Int32.TryParse(userInput, out index);
                validAnswer = false;
                for (int i = 0; i < possibleAnswers.Count; i++)
                {
                    if (userInput == possibleAnswers[i].Category.ToLower() || index == i + 1)
                    {
                        validAnswer = true;
                        break;
                    }
                }
                if (!validAnswer)
                {
                    Console.WriteLine("Invalid Input. That Category does not exist.");
                }
            } while (!validAnswer);
            return userInput;
        }
        private static bool ContinueGame()
        {
            string userInput;
            bool isValidResponse = false;
            bool continueGame = false;
            do
            {
                Console.Write("Do you want to continue (y/n)? ");
                userInput = Console.ReadLine().ToLower().Trim();
                if (((string[])["yes", "y", "no", "n"]).Contains(userInput))
                {
                    isValidResponse = true;
                    if (new string[] {"yes", "y"}.Contains(userInput))
                    {
                        continueGame = true;
                    } else
                    {
                        Console.WriteLine("Goodbye!");
                        continueGame = false;
                    }
                } else
                {
                    Console.WriteLine("Invalid Input. Please enter 'yes', 'y', 'no', or 'n'");
                    isValidResponse = false;
                }
            } while (!isValidResponse);
            return continueGame;
        }
    }
}
