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

            Console.WriteLine("EXERCISE 34!\n");
            do
            {
                PlayExercise34();
                continueGame = ContinueGame("Do you want to play Exercise 34 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 35!\n");
            do
            {
                PlayExercise35();
                continueGame = ContinueGame("Do you want to play Exercise 35 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 36!\n");
            do
            {
                PlayExercise36();
                continueGame = ContinueGame("Do you want to play Exercise 36 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 37!\n");
            do
            {
                PlayExercise37();
                continueGame = ContinueGame("Do you want to play Exercise 37 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 38!\n");
            do
            {
                PlayExercise38();
                continueGame = ContinueGame("Do you want to play Exercise 38 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 39!\n");
            do
            {
                PlayExercise39();
                continueGame = ContinueGame("Do you want to play Exercise 39 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 40!\n");
            do
            {
                PlayExercise40();
                continueGame = ContinueGame("Do you want to play Exercise 40 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 41!\n");
            do
            {
                PlayExercise41();
                continueGame = ContinueGame("Do you want to play Exercise 41 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 42!\n");
            do
            {
                PlayExercise42();
                continueGame = ContinueGame("Do you want to play Exercise 42 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 43!\n");
            do
            {
                PlayExercise43();
                continueGame = ContinueGame("Do you want to play Exercise 43 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 44!\n");
            do
            {
                PlayExercise44();
                continueGame = ContinueGame("Do you want to play Exercise 44 again? (y/n)? ");
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
        private static void PlayExercise34()
        {
            bool continueGame = true;
            string userInput;
            bool isValidInput;
            string outputMessage;
            double[] possibleValues = new double[] { 16, 32, 64, 128, 256 };
            do
            {
                Console.Write("Enter a command (half/double): ");
                userInput = Console.ReadLine().ToLower().Trim();
                isValidInput = IsValidResponse(userInput, 34);
                if (!isValidInput)
                {
                    continue;
                }
                if (userInput == "half")
                {
                    for (int i = 0; i < possibleValues.Length; i++)
                    {
                        possibleValues[i] /= 2;
                    }
                }
                else if (userInput == "double")
                {
                    for (int i = 0; i < possibleValues.Length; i++)
                    {
                        possibleValues[i] *= 2;
                    }
                }
                outputMessage = "The array now contains: ";
                for (int i = 0; i < possibleValues.Length;i++)
                {
                    if (i == possibleValues.Length - 1)
                    {
                        outputMessage += $"{possibleValues[i]}.";
                    } else
                    {
                        outputMessage += possibleValues[i].ToString() + ", ";
                    }
                }
                Console.WriteLine(outputMessage);
                continueGame = ContinueGame("Would you like to continue (y/n)? ");
            } while (continueGame);
        }
        private static void PlayExercise35()
        {
            bool continueGame = true;
            string userInput;
            bool isValidInput;
            bool errorMessage = false;
            int index1;
            int index2;
            string[] possibleValues = ["cow", "elephant", "jaguar", "horse", "crow"];
            do
            {
                Console.Write("Enter two indices: ");
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 35);
                if (!isValidInput)
                {
                    continue;
                }
                string[] splitUserInput = userInput.Split(' ');
                index1 = Int32.Parse(splitUserInput[0]);
                index2 = Int32.Parse(splitUserInput[1]);
                if (index1 < 0 || index2 < 0 || index1 > possibleValues.Length - 1)
                {
                    errorMessage = true;
                } else if (index2 > possibleValues[index1].Length -1)
                {
                    errorMessage = true;
                }
                if (errorMessage)
                {
                    Console.WriteLine("Those are not valid indices.");
                }
                else
                {
                    Console.WriteLine($"The value at index {index1} is {possibleValues[index1]}.  The letter at index {index2} is {possibleValues[index1][index2]}.");
                }
                continueGame = ContinueGame("Would you like to continue (y/n)? ");
            } while (continueGame);
        }
        private static void PlayExercise36()
        {
            bool continueGame = true;
            string userInput;
            bool isValidInput;
            const int MAX_SIZE = 5;
            int[] numbers = new int[MAX_SIZE] { 12, 11, 10, 9, 8 };
            string[] words = new string[MAX_SIZE] { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking" };

            do
            {
                Console.Write("Enter a command (sing/quit): ");
                userInput = Console.ReadLine().ToLower().Trim();
                isValidInput = IsValidResponse(userInput, 36);
                if (!isValidInput)
                {
                    continue;
                }
                if (userInput == "sing")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine($"{numbers[i]} {words[i]}");
                    }
                }
                if (userInput == "quit")
                {
                    continueGame = false;
                }
            } while (continueGame);
        }
        private static void PlayExercise37()
        {
            bool continueGame = true;
            string userInput;
            bool isValidInput;
            int userNumber;
            int sum = 0;
            string displayString = "";
            int userAttempts = 0;
            const int MAX_SIZE = 5;
            int[] numbers = new int[MAX_SIZE];
            do
            {
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 37);
                if (!isValidInput)
                {
                    continue;
                }
                userNumber = Int32.Parse(userInput);
                numbers[userAttempts] = userNumber;
                userAttempts++;
                if (userAttempts == MAX_SIZE)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i < numbers.Length - 1)
                        {
                            displayString += $"{numbers[i]} + ";
                        }
                        else 
                        { 
                            displayString += $"{numbers[i]} = "; 
                        }
                        sum += numbers[i];
                    }
                    Console.WriteLine(displayString + sum);
                    sum = 0;
                    userAttempts = 0;
                    displayString = "";
                    continueGame = ContinueGame("Would you like to continue (y/n)? ");
                }
            } while (continueGame);
        }
        private static void PlayExercise38()
        {
            bool continueGame = true;
            string userInput;
            bool isValidInput;
            int userNumber;
            int sum = 0;
            string displayString = "(";
            int userAttempts = 0;
            const int MAX_SIZE = 5;
            int[] numbers = new int[MAX_SIZE];
            do
            {
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 38);
                if (!isValidInput)
                {
                    continue;
                }
                userNumber = Int32.Parse(userInput);
                numbers[userAttempts] = userNumber;
                userAttempts++;
                if (userAttempts == MAX_SIZE)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i < numbers.Length - 1)
                        {
                            displayString += $"{numbers[i]} + ";
                        }
                        else
                        {
                            displayString += $"{numbers[i]})/{MAX_SIZE} = ";
                        }
                        sum += numbers[i];
                    }
                    displayString += $"{sum / MAX_SIZE}";
                    Console.WriteLine(displayString);
                    sum = 0;
                    userAttempts = 0;
                    displayString = "(";
                    continueGame = ContinueGame("Would you like to continue (y/n)? ");
                }
            } while (continueGame);
        }
        private static void PlayExercise39()
        {
            bool continueGame = true;
            string userInput;
            bool isValidInput;
            int userNumber;
            int sum = 0;
            string displayString = "";
            int userAttempts = 0;
            const int MAX_SIZE = 5;
            int[] numbers = new int[MAX_SIZE];
            do
            {
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 39);
                if (!isValidInput)
                {
                    continue;
                }
                userNumber = Int32.Parse(userInput);
                numbers[userAttempts] = userNumber;
                userAttempts++;
                if (userAttempts == MAX_SIZE)
                {
                    Array.Sort(numbers);
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i < numbers.Length - 1)
                        {
                            displayString += $"{numbers[i]} ";
                        }
                        else
                        {
                            displayString += numbers[i].ToString();
                        }
                    }
                    Console.WriteLine(displayString);
                    sum = 0;
                    userAttempts = 0;
                    displayString = "";
                    continueGame = ContinueGame("Would you like to continue (y/n)? ");
                }
            } while (continueGame);
        }
        private static void PlayExercise40()
        {
            bool continueGame = true;
            string userInput;
            bool isValidInput;
            int userNumber;
            string displayString = "The median of (";
            int userAttempts = 0;
            const int MAX_SIZE = 5;
            int[] numbers = new int[MAX_SIZE];
            do
            {
                Console.Write("Enter a number: ");
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 40);
                if (!isValidInput)
                {
                    continue;
                }
                userNumber = Int32.Parse(userInput);
                numbers[userAttempts] = userNumber;
                userAttempts++;
                if (userAttempts == MAX_SIZE)
                {
                    Array.Sort(numbers);
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i < numbers.Length - 1)
                        {
                            displayString += $"{numbers[i]}, ";
                        }
                        else
                        {
                            displayString += $"{numbers[i]}) is ";
                        }
                    }
                    if (MAX_SIZE % 2 == 0)
                    {
                        int middleIndex1 = (MAX_SIZE / 2) - 1;
                        int middleIndex2 = (MAX_SIZE / 2);
                        Console.WriteLine($"middleIndex1: {middleIndex1}");
                        Console.WriteLine($"middleIndex2: {middleIndex2}");
                        decimal median = ((decimal)(numbers[middleIndex1] + numbers[middleIndex2]) / 2);
                        displayString += median.ToString();
                    } else
                    {
                        decimal middleIndex = Math.Round(((decimal)MAX_SIZE / 2), 0, MidpointRounding.AwayFromZero) - 1;
                        displayString += numbers[Convert.ToInt32(middleIndex)];
                    }
                    Console.WriteLine(displayString);
                    userAttempts = 0;
                    displayString = "The median of (";
                    continueGame = ContinueGame("Would you like to continue (y/n)? ");
                }
            } while (continueGame);
        }
        private static void PlayExercise41()
        {
            bool continueGame = true;
            string userInput;
            bool isValidInput;
            int userNumber;
            decimal quotient = 0;
            string displayString = "";
            int userAttempts = 0;
            const int MAX_SIZE = 2;
            int[] numbers = new int[MAX_SIZE];
            do
            {
                if (userAttempts == 0)
                {
                    Console.Write("Enter a number: ");
                } else
                {
                    Console.Write("Enter another number: ");
                }
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 41);
                if (!isValidInput)
                {
                    continue;
                }
                userNumber = Int32.Parse(userInput);
                numbers[userAttempts] = userNumber;
                userAttempts++;
                if (userAttempts == MAX_SIZE)
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i == 0)
                        {
                            quotient = numbers[i];
                        } else
                        {

                            quotient /= numbers[i];
                        }
                        if (i < numbers.Length - 1)
                        {
                            displayString += $"{numbers[i]} / ";
                        }
                        else if (i == numbers.Length - 1)
                        {   
                            displayString += $"{numbers[i]} is approximately ";
                        }
                    }
                    quotient = Math.Round(quotient,2,MidpointRounding.AwayFromZero);
                    displayString += quotient.ToString() + ".";
                    Console.WriteLine(displayString);
                    userAttempts = 0;
                    displayString = "";
                    continueGame = ContinueGame("Would you like to continue (y/n)? ");
                }
            } while (continueGame);
        }
        private static void PlayExercise42()
        {
            bool continueGame = true;
            bool validYCoordinate = false;
            string userInput;
            bool isValidInput;
            int xCoordinate;
            int yCoordinate;
            string displayString = "";
            do
            {
                Console.Write("Enter an X coordinate: ");
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 42);
                if (!isValidInput)
                {
                    continue;
                }
                xCoordinate = Int32.Parse(userInput);
                do
                {
                    Console.Write("Enter an Y coordinate: ");
                    userInput = Console.ReadLine().Trim();
                    isValidInput = IsValidResponse(userInput, 42);
                    if (!isValidInput)
                    {
                        validYCoordinate = false;
                        continue;
                    }
                    validYCoordinate = true;
                } while (!validYCoordinate);
                yCoordinate = Int32.Parse(userInput);
                Point point = new Point(xCoordinate, yCoordinate);
                displayString = $"You have created a point object ({point.DisplayCordinates()}).";
                Console.WriteLine(displayString);
                continueGame = ContinueGame("Would you like to continue (y/n)? ");
            } while (continueGame);
        }
        private static void PlayExercise43()
        {
            bool continueGame = true;
            bool validYCoordinate = false;
            string userInput;
            bool isValidInput;
            int xCoordinate;
            int yCoordinate;
            string displayString = "";
            do
            {
                Console.Write("Enter an X coordinate: ");
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 43);
                if (!isValidInput)
                {
                    continue;
                }
                xCoordinate = Int32.Parse(userInput);
                do
                {
                    Console.Write("Enter an Y coordinate: ");
                    userInput = Console.ReadLine().Trim();
                    isValidInput = IsValidResponse(userInput, 43);
                    if (!isValidInput)
                    {
                        validYCoordinate = false;
                        continue;
                    }
                    validYCoordinate = true;
                } while (!validYCoordinate);
                yCoordinate = Int32.Parse(userInput);
                Point point = new Point(xCoordinate, yCoordinate);
                displayString = $"You have created a point object ({point.DisplayCordinates()}). It has a distance of {point.CalculateDistance().ToString()}.";
                Console.WriteLine(displayString);
                continueGame = ContinueGame("Would you like to continue (y/n)? ");
            } while (continueGame);
        }
        private static void PlayExercise44()
        {
            bool continueGame = true;
            bool validYCoordinate = false;
            string userInput;
            bool isValidInput;
            int[] xCoordinates = new int[2];
            int[] yCoordinates = new int[2];
            string[] splitUserInput;
            string displayString = "";
            do
            {
                Console.Write("Enter coordinates for a point: ");
                userInput = Console.ReadLine().Trim();
                isValidInput = IsValidResponse(userInput, 44);
                if (!isValidInput)
                {
                    continue;
                }
                splitUserInput = userInput.Split(' ');
                xCoordinates[0] = Int32.Parse(splitUserInput[0]);
                xCoordinates[1] = Int32.Parse(splitUserInput[1]);
                do
                {
                    Console.Write("Enter coordinates for another point: ");
                    userInput = Console.ReadLine().Trim();
                    isValidInput = IsValidResponse(userInput, 44);
                    if (!isValidInput)
                    {
                        validYCoordinate = false;
                        continue;
                    }
                    validYCoordinate = true;
                } while (!validYCoordinate);
                splitUserInput = userInput.Split(' ');
                yCoordinates[0] = Int32.Parse(splitUserInput[0]);
                yCoordinates[1] = Int32.Parse(splitUserInput[1]);
                Point point = new Point(xCoordinates, yCoordinates);
                displayString = $"The midpoint between ({point.DisplayGroupedXCordinates()}) and ({point.DisplayGroupedYCordinates()}) is ({point.CalculateMidpoint()}).";
                Console.WriteLine(displayString);
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
            if (((int[])[31, 32, 33, 37, 38, 39,40, 42, 43]).Contains(exerciseNumber))
            {
                isValidStatus = Int32.TryParse(userInput, out int number);
                if (!isValidStatus)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");
                }
            } else if (exerciseNumber == 34)
            {
                isValidStatus = ((string[]) ["half", "double"]).Contains(userInput);
                if (!isValidStatus)
                {
                    Console.WriteLine("Invalid Input. Please enter 'half' or 'double'.");
                }
            } else if (((int[])[35, 44]).Contains(exerciseNumber))
            {
                if (string.IsNullOrEmpty(userInput))
                {
                    isValidStatus = false;
                } else
                {
                    string[] splitUserInput = userInput.Split(' ');
                    if (splitUserInput.Length != 2)
                    {
                        isValidStatus = false;
                    } else if (!(isValidStatus = Int32.TryParse(splitUserInput[0], out int number1)))
                    {
                        isValidStatus = false;
                    }
                    else if (!(isValidStatus = Int32.TryParse(splitUserInput[1], out int number2)))
                    {
                        isValidStatus = false;
                    }
                } 
                if (!isValidStatus)
                {
                    Console.WriteLine($"Invalid Input. Please enter two { (exerciseNumber == 35 ? "indices" : exerciseNumber == 44 ? "numbers" : "")} separated by one space.");
                }
            } else if (exerciseNumber == 36)
            {
                if (string.IsNullOrEmpty(userInput))
                {
                    isValidStatus = false;
                } else if (!((string[]) ["sing", "quit"]).Contains(userInput))
                {
                    isValidStatus = false;
                }
                if (!isValidStatus)
                {
                    Console.WriteLine("Invalid Input. Please enter 'sing' or 'quit'.");
                }
            } else if (exerciseNumber == 41)
            {
                isValidStatus = Int32.TryParse(userInput, out int number);
                if (!isValidStatus)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");
                } else if (number == 0)
                {
                    isValidStatus = false;
                    Console.WriteLine("Invalid Input. Please enter a valid number greater then 0.");
                }
            }
                return isValidStatus;
        }
    }
}
