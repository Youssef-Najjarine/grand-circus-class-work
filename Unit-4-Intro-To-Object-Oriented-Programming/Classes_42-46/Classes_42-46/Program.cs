using System.Drawing;

namespace Classes_42_46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueGame;
            //Console.WriteLine("EXERCISE 42!\n");
            //do
            //{
            //    PlayExercise42();
            //    continueGame = ContinueGame("Do you want to play Exercise 42 again? (y/n)? ");
            //} while (continueGame);
            //Console.WriteLine("Goodbye!\n");

            //Console.WriteLine("EXERCISE 43!\n");
            //do
            //{
            //    PlayExercise43();
            //    continueGame = ContinueGame("Do you want to play Exercise 43 again? (y/n)? ");
            //} while (continueGame);
            //Console.WriteLine("Goodbye!\n");

            //Console.WriteLine("EXERCISE 44!\n");
            //do
            //{
            //    PlayExercise44();
            //    continueGame = ContinueGame("Do you want to play Exercise 44 again? (y/n)? ");
            //} while (continueGame);
            //Console.WriteLine("Goodbye!\n");

            //Console.WriteLine("EXERCISE 45!\n");
            //do
            //{
            //    PlayExercise45();
            //    continueGame = ContinueGame("Do you want to play Exercise 45 again? (y/n)? ");
            //} while (continueGame);
            //Console.WriteLine("Goodbye!\n");

            Console.WriteLine("EXERCISE 46!\n");
            do
            {
                PlayExercise46();
                continueGame = ContinueGame("Do you want to play Exercise 46 again? (y/n)? ");
            } while (continueGame);
            Console.WriteLine("Goodbye!\n");
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
        private static void PlayExercise45()
        {
            string userInput;
            double sideLength;
            bool isValidResponse = false;
            do
            {
                Console.Write("Enter a side length: ");
                userInput = Console.ReadLine().Trim();
                isValidResponse = IsValidResponse(userInput, 45);
            } while (!isValidResponse);
            sideLength = double.Parse(userInput);
            Square newSquare = new Square(sideLength, "Square", 4);
            Console.WriteLine($"The square has side length {newSquare.SideLength}.  Its area is {newSquare.Area} and its perimeter is {newSquare.Perimeter}.");
        }
        private static void PlayExercise46()
        {
            string userInput;
            bool isValidResponse = false;
            do
            {
                Console.Write("Enter the side lengths of a triangle: ");
                userInput = Console.ReadLine().Trim();
                isValidResponse = IsValidResponse(userInput,46);
            } while (!isValidResponse);
            string[] splitUserInput = userInput.Split(' ');
            Triangle newTriangle = new Triangle(double.Parse(splitUserInput[0]), double.Parse(splitUserInput[1]), double.Parse(splitUserInput[2]), "Triangle", 3);
            Console.WriteLine($"The triangle has side lengths {newTriangle.Side1Length}, {newTriangle.Side2Length}, and {newTriangle.Side3Length}.  Its area is {newTriangle.Area} and its perimeter is {newTriangle.Perimeter}.");
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
        private static bool IsValidResponse(string userInput, int exerciseNumber)
        {
            bool isValidStatus = true;
            if (((int[])[42, 43]).Contains(exerciseNumber))
            {
                isValidStatus = Int32.TryParse(userInput, out int number);
                if (!isValidStatus)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");
                }
            }
            else if (((int[])[44]).Contains(exerciseNumber))
            {
                if (string.IsNullOrEmpty(userInput))
                {
                    isValidStatus = false;
                }
                else
                {
                    string[] splitUserInput = userInput.Split(' ');
                    if (splitUserInput.Length != 2)
                    {
                        isValidStatus = false;
                    }
                    else if (!(isValidStatus = Int32.TryParse(splitUserInput[0], out int number1)))
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
                    Console.WriteLine($"Invalid Input. Please enter two {(exerciseNumber == 35 ? "indices" : exerciseNumber == 44 ? "numbers" : "")} separated by one space.");
                }
            }
            else if (exerciseNumber == 45)
            {
                double number;
                bool isValidNumber = double.TryParse(userInput, out number);
                if (string.IsNullOrEmpty(userInput))
                {
                    isValidStatus = false;
                } else if (!isValidNumber || number <= 0)
                {
                    isValidStatus = false;
                }
                if (!isValidStatus)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number.");
                }
            } else if (exerciseNumber == 46)
            {
                string[] splitUserInput = userInput.Split(' ');
                if (string.IsNullOrEmpty(userInput) || splitUserInput.Length != 3)
                {
                    isValidStatus = false;
                } else
                {
                    double num1 = -1;
                    double num2 = -1;
                    double num3 = -1;
                    bool isValidNumber = double.TryParse(splitUserInput[0], out num1);
                    isValidNumber = double.TryParse(splitUserInput[1], out num2);
                    isValidNumber = double.TryParse(splitUserInput[2], out num3);
                    if (!isValidNumber || num1 <= 0 || num2 <= 0 || num3 <= 0)
                    {
                        isValidStatus = false;
                    }
                }

                if (!isValidStatus)
                {
                    Console.WriteLine("Invalid Input. Please enter three valid numbers greater then zero seperated by a space.");
                }
            }
                return isValidStatus;
        }
    }
}

