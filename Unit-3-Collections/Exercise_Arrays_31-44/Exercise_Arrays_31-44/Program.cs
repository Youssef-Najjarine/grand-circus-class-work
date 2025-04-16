using System.Linq.Expressions;

namespace Exercise_Arrays_31_44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueGame;
            Console.WriteLine("EXERCISE 31!\n");
            do
            {
                PlayExercise31();
                continueGame = ContinueGame("Do you want to play Exercise 31 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 32!\n");
            do
            {
                PlayExercise32();
                continueGame = ContinueGame("Do you want to play Exercise 32 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 33!\n");
            do
            {
                PlayExercise33();
                continueGame = ContinueGame("Do you want to play Exercise 33 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");
        }
        private static void PlayExercise31()
        {
            bool continueGame = true;
            string userInput;
            bool isValidInput;
            int index;
            const int MAX_SIZE = 5;
            int[] possibleValues = new int[MAX_SIZE] { 2, 8, 0, 24, 51 };
            do
            {
                Console.Write("Enter an index of the array: ");
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput,31);
                if (!isValidInput)
                {
                    continue;
                }
                index = Int32.Parse(userInput);
                if (index < 0 || index >= MAX_SIZE)
                {
                    Console.WriteLine("That is not a valid index.");
                } else
                {
                    Console.WriteLine($"The value at index {index} is {possibleValues[index]}.");
                }
                    continueGame = ContinueGame("Would you like to continue (y/n)? ");
            } while (continueGame);
        }
        private static void PlayExercise32()
        {
            bool continueGame = true;
            string userInput;
            bool isValidInput;
            int userNumber;
            int[] possibleValues = [2, 8, 0, 24, 51];
            do
            {
                Console.Write("Enter a number: ");
                bool numberFound = false;
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 32);
                if (!isValidInput)
                {
                    continue;
                }
                userNumber = Int32.Parse(userInput);
                for (int i = 0; i < possibleValues.Length; i++)
                {
                    if (possibleValues[i] == userNumber)
                    {
                        Console.WriteLine($"The value {userNumber} can be found at index {i}.");
                        numberFound = true;
                        break;
                    }
                }
                if (!numberFound)
                {
                    Console.WriteLine("That value cannot be found in the array.");
                }
                continueGame = ContinueGame("Would you like to continue (y/n)? ");
            } while (continueGame);
        }
        private static void PlayExercise33()
        {
            bool continueGame = true;
            bool modifyIndex = false;
            string userInput;
            bool isValidInput;
            int index;
            const int MAX_SIZE = 5;
            int[] possibleValues = new int[MAX_SIZE] { 2, 8, 0, 24, 51 };
            do
            {
                Console.Write("Enter an index of the array: ");
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 33);
                if (!isValidInput)
                {
                    continue;
                }
                index = Int32.Parse(userInput);
                if (index < 0 || index >= MAX_SIZE)
                {
                    Console.Write("That is not a valid index. ");
                }
                else
                {
                    Console.Write($"The value at index {index} is {possibleValues[index]}. ");
                    modifyIndex = ContinueGame("Would you like to change it (y/n)? ");
                }
                if (modifyIndex)
                {
                    Console.Write($"Enter the new value at index {index}: ");
                    userInput = Console.ReadLine().Trim();
                    isValidInput = IsValidResponse(userInput, 33);
                    if (isValidInput)
                    {
                        possibleValues[index] = Int32.Parse(userInput);
                        Console.Write($"The value at index {index} is {possibleValues[index]}. ");
                    }
                }
                continueGame = ContinueGame("Would you like to continue (y/n)? ");
            } while (continueGame);
        }
        private static bool ContinueGame(string displayText)
        {
            bool continueGame = false;
            bool isValidStatus;
            string userInput;
            do 
            {
                Console.Write(displayText);
                userInput = Console.ReadLine().Trim().ToLower();
                if (new[] { "y", "n", "yes", "no" }.Contains(userInput))
                {
                    switch (userInput)
                    {
                        case "y":
                        case "yes":
                            continueGame = true;
                            isValidStatus = true;
                            break;
                        default:
                            isValidStatus = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter 'y', 'n', 'yes', or 'no'.");
                    isValidStatus = false;
                }
            } while (!isValidStatus);
            return continueGame;
        }
        private static bool IsValidResponse(string userInput,int exerciseNumber)
        {
            bool isValidStatus = true;
            if (((int[])[31,32,33]).Contains(exerciseNumber))
            {
                if (string.IsNullOrEmpty(userInput))
                {
                    isValidStatus = false;
                }
                else
                {
                    isValidStatus = Int32.TryParse(userInput,out int number);
                }
                if (!isValidStatus)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");
                }
            }
            return isValidStatus;
        }
    }
}
