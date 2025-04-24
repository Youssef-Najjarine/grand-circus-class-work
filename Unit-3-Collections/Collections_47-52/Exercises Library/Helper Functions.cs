using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_Library
{
    internal class Helper_Functions
    {
        public static bool ContinueGame(string question)
        {
            string userInput;
            bool validInput;
            bool continueGame;
            while (true)
            {
                Console.Write(question);
                userInput = Console.ReadLine().ToLower().Trim();
                validInput = (new[] { "yes", "y", "no", "n" }).Contains(userInput);
                continueGame = ((string[])["yes", "y"]).Contains(userInput);
                if (!validInput) {
                    Console.WriteLine("Invalid Entry. Please enter 'yes', 'y', 'no', or 'n'");
                    continue;
                }
                break;

            }
            return continueGame;
        }
    }
}
