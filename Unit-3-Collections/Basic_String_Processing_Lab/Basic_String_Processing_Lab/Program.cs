namespace Basic_String_Processing_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Split Sentence Game!\n");
            bool continueGame;
            do
            {
                PlaySplitSentence();
                continueGame = ContinueGame("Would you like to continue (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("Display strings Entered Game!\n");
            do
            {
                PlayStringsEntered();
                continueGame = ContinueGame("Would you like to play strings Entered Game again (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!");
        }
        private static void PlaySplitSentence()
        {
            string userInput;
            bool isValidEntry;
            do
            {
                Console.Write("Enter a sentence: ");
                userInput = Console.ReadLine();
                isValidEntry = IsValidEntry(userInput);
                if (!isValidEntry)
                {
                    Console.WriteLine("Invalid entry. Please enter a valid sentence.\n");
                }
            } while (!isValidEntry);
           
            string[] words = userInput.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
        private static void PlayStringsEntered()
        {
            string userInput;
            bool isValidEntry;
            bool playGame = true;
            List<string> words = new List<string>();
            while (playGame)
            {
                Console.Write("Enter some text: ");
                userInput = Console.ReadLine().Trim();
                isValidEntry = IsValidEntry(userInput);
                if (isValidEntry)
                {
                    words.Add(userInput);
                    Console.WriteLine($"You have entered: {String.Join(" ", words)}");
                    playGame = ContinueGame("Would you like to continue (y/n)? ");
                } else
                {
                    Console.WriteLine("Invalid entry. Please enter a valid string.\n");
                }
            }
        }
        private static Boolean IsValidEntry(string entry)
        {
            if (string.IsNullOrWhiteSpace(entry))
            {
                return false;
            }
            return true;
        }
        private static bool ContinueGame(string question)
        {
            string userInput;
            bool validResponse;

            do
            {
                Console.Write(question);
                userInput = Console.ReadLine().ToLower().Trim();
                string[] validResponses = ["y", "n", "no", "yes"];
                if (validResponses.Contains(userInput))
                {
                    validResponse = true;
                } else
                {
                    validResponse = false;
                    Console.WriteLine("Invalid response. Please enter 'y','n','yes', or 'no'");
                }
            } while (!validResponse);
            if (((string[]) [ "y", "yes" ]).Contains(userInput))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
