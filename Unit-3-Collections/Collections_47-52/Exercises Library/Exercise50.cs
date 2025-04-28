using helperFuncs = Exercises_Library.Helper_Functions;
namespace Exercises_Library
{
    public class Exercise50
    {
        public void Run()
        {
            Console.WriteLine("\nEXERCISE 50!\n");
            List<Triangle> triangles = new List<Triangle>();
            string userInput;
            string displayString = "";
            bool validInput;
            bool continueGame;
            while (true)
            {
                Console.Write("Enter a number (q to quit): ");
                userInput = Console.ReadLine().ToLower().Trim();
                validInput = helperFuncs.IsValidResponse(userInput, 50);
                if (!validInput)
                {
                    continue;
                }
                if (userInput == "q" || userInput == "quit")
                {
                    if (triangles.Count == 0)
                    {
                        continueGame = helperFuncs.ContinueGame("Would you like to continue (y/n)? ");
                        if (continueGame)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        double averageArea = Math.Round((double) triangles.Sum(t => t.GetArea()) / triangles.Count,2);
                        double averagePerimeter = Math.Round((double) triangles.Sum(t => t.GetPerimeter()) / triangles.Count,2);
                        displayString = $"Average Area: {averageArea}";
                        Console.WriteLine(displayString);
                        displayString = $"Average Perimeter: {averagePerimeter}";
                        Console.WriteLine(displayString);
                        continueGame = helperFuncs.ContinueGame("Would you like to continue (y/n)? ");
                        if (continueGame)
                        {
                            triangles.Clear();
                            displayString = "";
                            continue;
                        }
                    }
                }
                else
                {
                    string[] sides = userInput.Split(' ');
                    Triangle triangle = new Triangle(double.Parse(sides[0]), double.Parse(sides[1]), double.Parse(sides[2]));
                    triangles.Add(triangle);
                    continue;
                }
                continueGame = helperFuncs.ContinueGame("Would you like to play Exercise 50 again (y/n)? ");
                if (!continueGame)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else
                {
                    triangles.Clear();
                    displayString = "";
                }

            }
        }
    }
    internal class Triangle
    {
        private double _Side1;
        private double _Side2;
        private double _Side3;
        private double _Perimeter;
        public double _Area;
        public Triangle(double side1, double side2, double side3)
        {
            this._Side1 = Math.Round(side1,2);
            this._Side2 = Math.Round(side2,2);
            this._Side3 = Math.Round(side3,2);
            this._Perimeter = this._Side1 + this._Side2 + this._Side3;
            double semiPerimeter = this._Perimeter / 2;
            this._Area = Math.Sqrt(semiPerimeter * (semiPerimeter - this._Side1) * (semiPerimeter - this._Side2) * (semiPerimeter - this._Side3));
        }
        public double GetPerimeter()
        {
            return this._Perimeter;
        }
        public double GetArea()
        {
            return this._Area;
        }
    }
}
