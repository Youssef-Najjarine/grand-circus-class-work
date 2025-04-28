using System.Globalization;
using helperFuncs = Exercises_Library.Helper_Functions;
namespace Exercises_Library
{
    public class Exercise52
    {
        public void Run()
        {
            Console.WriteLine("\nEXERCISE 52!\n");
            string userInput;
            bool validInput;
            bool continueGame;
            int shapeType;
            double shapeLength;
            Dictionary<string, List<object>> shapes = new Dictionary<string, List<object>>()
            {
                { "square", new List<object>() },
                { "triangle", new List<object>() },
                { "circle", new List<object>() }
            };
            while (true)
            {
                Console.Write("Enter a new shape.  Square (1), Triangle (2), Circle(3), Quit(q): ");
                userInput = Console.ReadLine().ToLower().Trim();
                validInput = helperFuncs.IsValidResponse(userInput, 52);
                if (!validInput)
                {
                    continue;
                }
                if (new[] {"q", "quit"}.Contains(userInput))
                {
                    DisplayAverages(shapes);
                } else
                {
                    shapeType = Int32.Parse(userInput);
                    if (shapeType == 1)
                    {
                        do
                        {
                            Console.Write("Enter a side length: ");
                            userInput = Console.ReadLine().ToLower().Trim();
                            validInput = helperFuncs.IsValidResponse(userInput, 49);
                            if (new[] { "q", "quit" }.Contains(userInput))
                            {
                                validInput = true;
                            }
                        } while (!validInput);
                        if (!(new[] { "q", "quit" }.Contains(userInput)))
                        {
                            shapeLength = double.Parse(userInput);
                            shapes["square"].Add(new Square(shapeLength));
                        } else
                        {
                            DisplayAverages(shapes);
                        }
                    } else if (shapeType == 2)
                    {
                        do
                        {
                            Console.Write("Enter the side lengths of a triangle: ");
                            userInput = Console.ReadLine().ToLower().Trim();
                            validInput = helperFuncs.IsValidResponse(userInput, 50);
                            if (new[] { "q", "quit" }.Contains(userInput))
                            {
                                validInput = true;
                            }
                        } while (!validInput);
                        if (!(new[] { "q", "quit" }.Contains(userInput)))
                        {
                            string[] sides = userInput.Split(' ');
                            Triangle triangle = new Triangle(double.Parse(sides[0]), double.Parse(sides[1]), double.Parse(sides[2]));
                            shapes["triangle"].Add(triangle);
                        }
                        else
                        {
                            DisplayAverages(shapes);
                        }
                    } else if (shapeType == 3)
                    {
                        do
                        {
                            Console.Write("Enter the radius: ");
                            userInput = Console.ReadLine().ToLower().Trim();
                            validInput = helperFuncs.IsValidResponse(userInput, 49);
                            if (new[] { "q", "quit" }.Contains(userInput))
                            {
                                validInput = true;
                            }
                        } while (!validInput);
                        if (!(new[] { "q", "quit" }.Contains(userInput)))
                        {
                            shapeLength = double.Parse(userInput);
                            shapes["circle"].Add(new Circle(shapeLength));
                        }
                        else
                        {
                            DisplayAverages(shapes);
                        }
                    }

                }
                    continueGame = helperFuncs.ContinueGame("Would you like to continue (y/n)? ");
                if (continueGame)
                {
                    continue;
                }
                continueGame = helperFuncs.ContinueGame("Would you like to play Exercise 52 again (y/n)? ");
                if (!continueGame)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                } else
                {
                    foreach (List<object> list in shapes.Values)
                    {
                        list.Clear();
                    }
                }

            }
        }
        private void DisplayAverages(Dictionary<string, List<object>> shapes)
        {
            string displayString;
            double shapeCount = 0;
            double areaSum = 0;
            double perimeterSum = 0;
            foreach (KeyValuePair<string,List<object>> shape in shapes)
            {
                if (shape.Value.Count > 0)
                {
                    foreach (object item in shape.Value)
                    {
                        var shapeType = item.GetType();
                        shapeCount++;
                        
                        if (shape.Key == "square")
                        {
                            areaSum += ((Square)item).GetArea();
                            perimeterSum += ((Square)item).GetSumOfSides();
                        } else if (shape.Key == "triangle") {
                            areaSum += ((Triangle)item).GetArea();
                            perimeterSum += ((Triangle)item).GetPerimeter();
                        } else if (shape.Key == "circle") {
                            areaSum += ((Circle)item).GetArea();
                            perimeterSum += ((Circle)item).GetPerimeter();
                        }
                    }
                }
            }
            displayString = $"Average Area: {Math.Round(areaSum / shapeCount,2)}\n";
             displayString += $"Average Perimeter: {Math.Round(perimeterSum / shapeCount,2)}";
            Console.WriteLine(displayString);
        }
        internal class Circle
        {
            private double _Radius;
            public Circle(double radius)
            {
                this._Radius = radius;
            }
            public double GetArea()
            {
                return Math.Round(Math.PI * (this._Radius * this._Radius), 2);
            }
            public double GetPerimeter()
            {
                return Math.Round(Math.PI * (2 * this._Radius), 2);
            }
        }
    }
}
