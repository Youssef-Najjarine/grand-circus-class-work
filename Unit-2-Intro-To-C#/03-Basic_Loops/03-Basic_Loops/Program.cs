namespace _03_Basic_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Game.\n");
            bool continueGame = false;
            do
            {
                Console.WriteLine("Hello, World!");
                Console.Write("Would you like to continue (y/n)? ");
                continueGame = Console.ReadLine().ToLower().Trim() == "y";
                if (!continueGame)
                {
                    Console.WriteLine("Goodbye!\n");
                }
            } while (continueGame);

            Console.WriteLine("List Numbers Game.\n");
            string userResponse;
            int userNumber;
            bool validNumber = false;
            do
            {

                do
                {
                    Console.Write("Enter a number: ");
                    userResponse = Console.ReadLine().Trim();
                    validNumber = int.TryParse(userResponse, out userNumber);
                    if (!validNumber)
                    {
                        Console.WriteLine("Invalid Entry.");
                    }
                } while (!validNumber);
                if (!validNumber)
                {
                    Console.WriteLine("Invalid Entry.");
                    continue;
                }
                string userNumberToZero = "";
                string zeroToUserNumber = "";
                for (int i = userNumber; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        userNumberToZero += i.ToString();
                    } else
                    {
                        userNumberToZero += i.ToString() + " ";
                    }
                }
                for (int i = 0; i <= userNumber; i++)
                {
                    if (i == userNumber)
                    {
                        zeroToUserNumber += i.ToString();
                    } else
                    {
                        zeroToUserNumber += i.ToString() + " ";
                    }
                }
                Console.WriteLine(userNumberToZero);
                Console.WriteLine(zeroToUserNumber);
                Console.Write("Would you like to continue (y/n)? ");
                continueGame = Console.ReadLine().ToLower().Trim() == "y";
                if (!continueGame)
                {
                    Console.WriteLine("Goodbye!\n");
                }
            } while (continueGame);

            Console.WriteLine("Keypad Entry Game. (While Loop)\n");
            bool doorLocked = true;
            int correctCode = 13579;
            int maxAttempts = 5;
            int attempts = 0;
            while (doorLocked || attempts < maxAttempts)
            {
                if (attempts >= maxAttempts)
                {
                    Console.WriteLine("Warning, too many attempts. The door is now locked.");
                    break;
                }
                do
                {
                    Console.Write("Please enter a key code: ");
                    userResponse = Console.ReadLine().Trim();
                    validNumber = int.TryParse(userResponse, out userNumber);
                    if (!validNumber)
                    {
                        Console.WriteLine("Invalid Entry. Please enter a number.");
                    }
                } while (!validNumber);
               if (userNumber == correctCode)
                {
                    Console.WriteLine("Correct code entered. Welcome!");
                    doorLocked = false;
                    break;
                } else
                {
                    Console.WriteLine("Incorect code entered.");
                    attempts++;
                }
            }
        }
    }
}
