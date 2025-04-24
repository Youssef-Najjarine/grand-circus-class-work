using helperFuncs = Exercises_Library.Helper_Functions;
namespace Exercises_Library
{
    public class Exercise47
    {
        public void Run()
        {
            while (true)
            {
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
