using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using static Enumerations_57_62.Card;

namespace Enumerations_57_62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string continueString;
            do
            {
                //Console.WriteLine("\nEXERCISE 57!\n");
                //Exercise57();
                continueString = "\nWould you like to continue (y/n)? ";

                //Console.WriteLine("\nEXERCISE 58!\n");
                //Exercise58();

                //Console.WriteLine("\nEXERCISE 60!\n");
                //Exercise60();

                //Console.WriteLine("\nEXERCISE 61!\n");
                //Exercise61();

            } while (ContinueGame(continueString));
        }
        private static void Exercise57()
        {
            string userInput;
            bool validInput = false;
            string player1Answer = "";
            string player2Answer = "";
            do
            {
                Console.Write("Player 1, enter rock (r), paper (p), or scissors(s): ");
                userInput = Console.ReadLine().ToLower().Trim();
                validInput = CheckUserResponse(userInput, 57);
            } while (!validInput);
            player1Answer = userInput;
            do
            {
                Regex regex = new Regex(player1Answer);
                string player1Asterisk = regex.Replace(player1Answer, new string('*', player1Answer.Length));
                Console.WriteLine($"Player 1 entered {player1Asterisk}");
                Console.Write("Player 2, enter rock (r), paper (p), or scissors(s): ");
                userInput = Console.ReadLine().ToLower().Trim();
                validInput = CheckUserResponse(userInput, 57);
            } while (!validInput);
            player2Answer = userInput;
            string winner = CalculateRockPaperScissorsWinner(player1Answer, player2Answer);
            Console.WriteLine(winner);
        }
        private static string CalculateRockPaperScissorsWinner(string player1, string player2)
        {
            string winner = "";
            string player1Answer = "";
            string player2Answer = "";
            if (player1 == "r" || player1 == "rock")
            {

                player1Answer = "rock";
            }
            else if (player1 == "p" || player1 == "paper")
            {
                player1Answer = "paper";
            }
            else if (player1 == "s" || player1 == "scissors")
            {
                player1Answer = "scissors";
            }
            if (player2 == "r" || player2 == "rock")
            {

                player2Answer = "rock";
            }
            else if (player2 == "p" || player2 == "paper")
            {
                player2Answer = "paper";
            }
            else if (player2 == "s" || player2 == "scissors")
            {
                player2Answer = "scissors";
            }
            if (player1Answer == player2Answer)
            {
                winner = "It's a tie!";
            }
            else if ((player1Answer == "rock" && player2Answer == "scissors")
                || (player1Answer == "scissors" && player2Answer == "paper")
                || (player1Answer == "paper" && player2Answer == "rock"))
            {
                winner = "Player 1 wins!";
            }
            else if ((player2Answer == "rock" && player1Answer == "scissors")
                || (player2Answer == "scissors" && player1Answer == "paper")
                || (player2Answer == "paper" && player1Answer == "rock"))
            {
                winner = "Player 2 wins!";
            }
            return winner;
        }
        private static void Exercise58()
        {
            string displayString = "";
            displayString += "Suit => ";
            foreach (Enum suit in Enum.GetValues(typeof(Suits)))
            {
                displayString += suit + ", ";
            }
            displayString = displayString.TrimEnd(' ', ',');
            displayString = String.Format("\n{0}", displayString);
            Console.WriteLine(displayString);
            displayString = "";
            displayString += "Browser => ";

            foreach (Enum browser in Enum.GetValues(typeof(Browsers)))
            {
                displayString += browser + ", ";
            }
            displayString = displayString.TrimEnd(' ', ',');
            displayString = String.Format("\n{0}", displayString);
            Console.WriteLine(displayString);
            displayString = "";
            displayString += "Brand => ";
            foreach (Enum brand in Enum.GetValues(typeof(Brands)))
            {
                displayString += brand + ", ";
            }
            displayString = displayString.TrimEnd(' ', ',');
            displayString = String.Format("\n{0}", displayString);
            Console.WriteLine(displayString);
            displayString = "";
            displayString += "Day => ";
            foreach(Enum day in Enum.GetValues(typeof(Days)))
            {
                displayString += day + ", ";
            }
            displayString = displayString.TrimEnd(' ', ',');
            displayString = String.Format("\n{0}", displayString);
            Console.WriteLine(displayString);
        }
        enum Suits
        {
            Diamonds,
            Hearts,
            Clubs,
            Spades
        }
        enum Browsers
        {
            Chrome,
            Firefox,
            IE,
            Opera
        }
        enum  Brands 
        {
            Polo,
            Gucci,
            Armani,
            Athleta
        }
        enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        private static void Exercise60()
        {
            Deck deck = new Deck();
            object firstCard = deck.DeckOfCards[0];
            object suit = firstCard.GetType().GetProperty("suit").GetValue(firstCard);
            object rank = firstCard.GetType().GetProperty("rank").GetValue(firstCard);
            Console.WriteLine($"Shuffling... You drew a {rank} of {suit}.");
        }
        private static void Exercise61()
        {
            Circle circle = new Circle(5, "Circle", 0);
            Console.WriteLine($"Shape: {circle.ShapeName}, Sides: {circle.SidesCount}, Area: {circle.Area}, Perimeter: {circle.Perimeter}");
            Square square = new Square(7, "Square", 4);
            Console.WriteLine($"Shape: {square.ShapeName}, Sides: {square.SidesCount}, Area: {square.Area}, Perimeter: {square.Perimeter}");
            Triangle triangle = new Triangle(3, 4, 5, "Triangle", 3);
            Console.WriteLine($"Shape: {triangle.ShapeName}, Sides: {triangle.SidesCount}, Area: {triangle.Area}, Perimeter: {triangle.Perimeter}");
        }
        private static bool CheckUserResponse(string userInput, int exerciseNumber)
        {
           bool result = false;

           if (exerciseNumber == 57)
            {
                string[] possibleAnswers = ["rock", "r", "paper", "p", "scissors", "s"];
                if (possibleAnswers.Contains(userInput))
                {
                    result = true;
                } else
                {
                    Console.WriteLine("Invalid input. Please enter 'rock', 'r', 'paper', 'p', 'scissors', or 's'.");
                }
            }
            return result;
        }
        private static bool ContinueGame(string userInput)
        {
            bool continueGame = false;
            bool validResponse = false;
            string userResponse;

            do
            {
                Console.Write(userInput);
                userResponse = Console.ReadLine().ToLower().Trim();
                if (new string[] {"yes", "y", "no", "n"}.Contains(userResponse))
                {
                    validResponse = true;
                    if (((string[]) ["yes", "y"]).Contains(userResponse))
                    {
                        continueGame = true;
                    } else
                    {
                        Console.WriteLine("Goodbye!");
                    }
                }
                if (!validResponse)
                {
                    Console.WriteLine("Invalid response. Please enter 'yes', 'y', 'no' or 'n'.");
                }
            } while (!validResponse);
            return continueGame;
        }
    }
}
