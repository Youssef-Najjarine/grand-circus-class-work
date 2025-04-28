using helperFuncs = Exercises_Library.Helper_Functions;
namespace Exercises_Library
{
    public class Exercise47
    {
        public void Run()
        {
            Console.WriteLine("\nEXERCISE 47!\n");
            string userInput;
            while (true)
            {
                Console.Write("Enter some text:");
                userInput = Console.ReadLine().ToLower().Trim();
                Console.WriteLine("You have entered: " + userInput);
                bool continueGame = helperFuncs.ContinueGame("Would you like to continue (y/n)?");
                if (!continueGame)
                {
                    continueGame = helperFuncs.ContinueGame("Would you like to play Exercise 47 again (y/n)?");
                    if (!continueGame)
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                }
            }
        }
    }
}
