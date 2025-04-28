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
        public static bool IsValidResponse(string userInput, int exerciseNumber)
        {
            bool validInput = false;
            double doubleNumber;
            int intNumber;
            if ((new[] {48}).Contains(exerciseNumber))
            {
                validInput = double.TryParse(userInput, out doubleNumber) || ((string[]) ["q", "quit"]).Contains(userInput);
                
                if (!validInput)
                {
                    Console.WriteLine($"Invalid entry. Please enter a valid number or enter 'q' or 'quit' to exit the program.");
                }
            } else if ((new[] { 49 }).Contains(exerciseNumber))
            {
                validInput = double.TryParse(userInput, out doubleNumber) || ((string[])["q", "quit"]).Contains(userInput);

                if (!validInput)
                {
                    Console.WriteLine($"Invalid entry. Please enter a valid number or enter 'q' or 'quit' to exit the program.");
                }
                else if (doubleNumber <= 0 && !(new[] { "q", "quit" }).Contains(userInput))
                {
                    validInput = false;
                    Console.WriteLine($"Invalid entry. Please enter a valid positive number or enter 'q' or 'quit' to exit the program.");
                }
            } else if (((int[]) [50]).Contains(exerciseNumber))
            {
                double num1;
                double num2;
                double num3;
                if ((new[] { "q", "quit" }).Contains(userInput))
                {
                    validInput = true;
                } else
                {
                    string[] splitInput = userInput.Split(' ');
                    if (splitInput.Length != 3)
                    {
                        validInput = false;
                        Console.WriteLine("Invalid Input. Please enter three valid positive numbers seperated by one space or enter 'q' or 'quit' to exit the program.");
                    } else
                    {
                        bool validDouble1 = double.TryParse(splitInput[0], out num1);
                        bool validDouble2 = double.TryParse(splitInput[1], out num2);
                        bool validDouble3 = double.TryParse(splitInput[2], out num3);
                        if (!validDouble1 || !validDouble2 || !validDouble3)
                        {
                            validInput = false;
                            Console.WriteLine("Invalid Input. Please enter three valid positive numbers seperated by one space or enter 'q' or 'quit' to exit the program.");
                        } else
                        {
                            if (num1 <= 0 || num2 <= 0 || num3 <= 0)
                            {
                                validInput = false;
                                Console.WriteLine("Invalid Input. Please enter three valid positive numbers seperated by one space or enter 'q' or 'quit' to exit the program.");
                            }
                            else
                            {
                                validInput = true;
                            }
                        }
                    }
                }
            } else if (((int[]) [51]).Contains(exerciseNumber)) {
                if (String.IsNullOrEmpty(userInput))
                {
                    validInput = false;
                    Console.WriteLine("Invalid Input. Please input a valid entry.");
                }
                else
                {
                    validInput = true;
                }
            } else if (((int[])[52]).Contains(exerciseNumber))
            {
                validInput = Int32.TryParse(userInput, out intNumber) || ((string[])["q", "quit"]).Contains(userInput);
                if ((new[] { "q", "quit" }).Contains(userInput))
                {
                    validInput = true;
                } else
                {
                    if (((int[])[1,2,3]).Contains(intNumber))
                    {
                        validInput = true;
                    }
                    else
                    {
                        validInput = false;
                        Console.WriteLine("Invalid Input. Please enter a valid number (1, 2, or 3) or enter 'q' or 'quit' to exit the program.");
                    }
                }
            }
                return validInput;
        }
    }
}
