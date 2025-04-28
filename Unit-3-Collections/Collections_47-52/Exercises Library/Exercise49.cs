using helperFuncs = Exercises_Library.Helper_Functions;
namespace Exercises_Library
{
    public class Exercise49
    {
        public void Run()
        {
            Console.WriteLine("\nEXERCISE 49!\n");
            List<Square> squares = new List<Square>();
            string userInput;
            double userNumber;
            string displayString = "";
            bool validInput;
            bool continueGame;
            while (true)
            {
                Console.Write("Enter a number (q to quit): ");
                userInput = Console.ReadLine().ToLower().Trim();
                validInput = helperFuncs.IsValidResponse(userInput, 49);
                if (!validInput)
                {
                    continue;
                }
                if (userInput == "q" || userInput == "quit")
                {
                    if (squares.Count == 0)
                    {
                        continueGame = helperFuncs.ContinueGame("Would you like to continue (y/n)? ");
                        if (continueGame)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        displayString = $"You have created {squares.Count} squares";
                        Console.WriteLine(displayString);
                        double maxValue = squares.Max(square => square.GetSideLength());
                        double minValue = squares.Min(square => square.GetSideLength());
                        double area = Math.Round(squares.Sum(square => square.GetArea()) / squares.Count,2);
                        double perimeter = Math.Round(squares.Sum(square => square.GetSumOfSides()) / squares.Count,2);
                        displayString = $"Largest: {maxValue}";
                        Console.WriteLine(displayString);
                        displayString = $"Smallest: {minValue}";
                        Console.WriteLine(displayString);
                        displayString = $"Average Area: {area}";
                        Console.WriteLine(displayString);
                        displayString = $"Average Perimeter: {perimeter}";
                        Console.WriteLine(displayString);
                        continueGame = helperFuncs.ContinueGame("Would you like to continue (y/n)? ");
                        if (continueGame)
                        {
                            squares.Clear();
                            displayString = "";
                            continue;
                        }
                    }
                }
                else
                {
                    userNumber = double.Parse(userInput);
                    Square square = new Square(userNumber);
                    squares.Add(square);
                    continue;
                }
                continueGame = helperFuncs.ContinueGame("Would you like to play Exercise 49 again (y/n)? ");
                if (!continueGame)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    squares.Clear();
                    displayString = "";
                }

            }
        }
    }
    internal class Square
    {
        private double _SideLength;
        private double _SumOfSides;
        public double _Area;
        public Square(double sideLength)
        {
            this._SideLength = sideLength;
            this._SumOfSides = this._SideLength * 4;
            this._Area = Math.Round(this._SideLength * this._SideLength,2);

        }
        public double GetSideLength()
        {
            return _SideLength;
        }
        public double GetSumOfSides()
        {
            return _SumOfSides;
        }
        public double GetArea()
        {
            return _Area;
        }
    }
}
