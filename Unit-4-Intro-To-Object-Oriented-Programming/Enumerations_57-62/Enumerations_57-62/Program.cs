using System.Runtime.CompilerServices;

namespace Enumerations_57_62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continueString;
            do
            {
                Console.WriteLine("\nEXERCISE 57!\n");
                Exercise57();
                continueString = "Would you like to continue (y/n)? ";
            } while (ContinueGame(continueString));
        }
        private static void Exercise57()
        {

        }
        private static bool ContinueGame(string userInput)
        {
            bool continueGame = false;
            bool validResponse = false;
            string userResponse;

            do
            {
                Console.Write(userInput);
                userResponse = Console.ReadLine().ToLower().Trim();
                if (new string[] {"yes", "y", "no", "n"}.Contains(userResponse))
                {
                    validResponse = true;
                    if (((string[]) ["yes", "y"]).Contains(userResponse))
                    {
                        continueGame = true;
                    } else
                    {
                        Console.WriteLine("Goodbye!");
                    }
                }
                if (!validResponse)
                {
                    Console.WriteLine("Invalid response. Please enter 'yes', 'y', 'no' or 'n'.");
                }
            } while (!validResponse);
            return continueGame;
        }
    }
}
