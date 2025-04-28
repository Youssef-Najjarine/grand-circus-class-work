using System.Linq;
using helperFuncs = Exercises_Library.Helper_Functions;
namespace Exercises_Library
{
    public class Exercise51
    {
        public void Run()
        {
            Dictionary<string, string> translator = new Dictionary<string, string>
            {
                { "hello", "hola" },
                { "food", "comida" },
                { "world", "mundo" },
                { "computer", "computadora"},
                { "exercise", "ejercicio"}

            };
            Console.WriteLine("\nEXERCISE 51!\n");
            string userInput;
            bool validInput;
            bool continueGame;
            while (true)
            {
                Console.Write("Enter a word in English: ");
                userInput = Console.ReadLine().ToLower().Trim();
                validInput = helperFuncs.IsValidResponse(userInput, 51);
                if (!validInput)
                {
                    continue;
                }
                if (translator.ContainsKey(userInput))
                {
                    Console.WriteLine($"{userInput} in Spanish is {translator[userInput]}.");
                }
                else
                {
                    Console.WriteLine($"{userInput} cannot be translated.");
                }
                continueGame = helperFuncs.ContinueGame("Would you like to continue (y/n)? ");
                if (continueGame)
                {
                    continue;
                }
                continueGame = helperFuncs.ContinueGame("Would you like to play Exercise 51 again (y/n)? ");
                if (!continueGame)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }


            }
        }
    }
}
