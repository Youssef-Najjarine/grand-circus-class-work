namespace _02_Number_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Number Analyzer App. Please enter your name: ");
            string userName = Console.ReadLine();
            bool playGame = true;
            // Start game loop
            do
            {
                string userResponse;
                int userNumber;
                bool validInteger = false;
                // Start valid integer entered loop
                do
                {
                    Console.Write($"\n{userName} please enter an integer between 1 and 100: ");
                    userResponse = Console.ReadLine().Trim();
                    validInteger = int.TryParse(userResponse, out userNumber);
                    if (!validInteger || userNumber < 1 || userNumber > 100)
                    {
                        Console.WriteLine("Invalid input.");
                        validInteger = !(userNumber < 1 || userNumber > 100);
                    }
                } while (!validInteger);
                // End valid integer entered loop
                if (userNumber % 2 != 0 && userNumber < 60)
                {
                    Console.WriteLine($"{userNumber} is Odd and less than 60.");
                }
                {

                }
                Console.Write($"\nDo you want to play again {userName}? (Yes/No): ");
                userResponse = Console.ReadLine().ToLower().Trim();
                if (userResponse == "yes" || userResponse == "y")
                {
                    continue;
                } else
                {
                    Console.WriteLine($"Thanks for playing! See you next time {userName}!");
                    playGame = false;
                }
            } while (playGame);
            // End game loop
        }
    }
}
