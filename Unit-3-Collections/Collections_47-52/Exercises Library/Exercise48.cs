using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helperFuncs = Exercises_Library.Helper_Functions;

namespace Exercises_Library
{
    public class Exercise48
    {
        public void Run()
        {
            Console.WriteLine("\nEXERCISE 48!\n");
            List<double> numbersEntered = new List<double>();
            string userInput;
            double userNumber;
            string displayString = "";
            bool validInput;
            bool continueGame;
            while (true)
            {
                Console.Write("Enter a number (q to quit): ");
                userInput = Console.ReadLine().ToLower().Trim();
                validInput = helperFuncs.IsValidResponse(userInput, 48);
                if (!validInput)
                {
                    continue;
                }
                if (userInput == "q" || userInput == "quit")
                {
                    if (numbersEntered.Count == 0)
                    {
                        continueGame = helperFuncs.ContinueGame("Would you like to continue (y/n)? ");
                        if (continueGame)
                        {
                            continue;
                        }
                    } else
                    {
                        for (int i = 0; i < numbersEntered.Count; i++)
                        {
                            if (i < numbersEntered.Count - 1)
                            {
                                displayString += numbersEntered[i].ToString() + " + ";
                            } else
                            {
                                displayString += numbersEntered[i].ToString() + " = ";
                            }
                        }
                        displayString += Math.Round(numbersEntered.Sum(),2).ToString();
                        Console.WriteLine(displayString);
                        continueGame = helperFuncs.ContinueGame("Would you like to continue (y/n)? ");
                        if (continueGame)
                        {
                            numbersEntered.Clear();
                            displayString = "";
                            continue;
                        }
                    }
                } else
                {
                    userNumber = double.Parse(userInput);
                    numbersEntered.Add(userNumber);
                    continue;
                }
                continueGame = helperFuncs.ContinueGame("Would you like to play Exercise 48 again (y/n)? ");
                if (!continueGame)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                } else
                {
                    numbersEntered.Clear();
                    displayString = "";
                }

            }
        }
    }
}
