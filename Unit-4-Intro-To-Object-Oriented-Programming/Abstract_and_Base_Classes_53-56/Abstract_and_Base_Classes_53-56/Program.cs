namespace Abstract_and_Base_Classes_53_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nEXERCISE 54\n");
            do
            {
                Exercise54();
            } while (ContinuGame("Would you like to continue (y/n)? "));
        }
        private static void Exercise54()
        {
            string userInput;
            double num1 = - 1;
            double num2 = -1;
            double num3 = -1;

            // Square Section
            do
            {
                Console.WriteLine("\nSquare Section!\n");
                Console.Write("Enter a side length: ");
                userInput = Console.ReadLine().Trim();
            } while (!IsValidResponse(userInput, "Square"));
            Square newSquare = new Square(double.Parse(userInput), "Square", 4);
            Console.WriteLine($"The square has side length of {newSquare.SideLength}. The area is {newSquare.Area} and the its perimeter is {newSquare.Perimeter}.");

            // Triangle Section
            string[] triangleInputs;
            Triangle newTriangle;
            bool isValidTriangleInputs = false;
            do
            {
                Console.WriteLine("\nTriangle Section!\n");
                Console.Write("Enter the side lengths of a triangle: ");
                userInput = Console.ReadLine().Trim();
                isValidTriangleInputs = IsValidResponse(userInput, "Triangle");
                if (isValidTriangleInputs)
                {
                    triangleInputs = userInput.Split(' ');
                    num1 = double.Parse(triangleInputs[0]);
                    num2 = double.Parse(triangleInputs[1]);
                    num3 = double.Parse(triangleInputs[2]);
                    newTriangle = new Triangle(num1, num2, num3, "Triangle", 3);
                    if (
                      double.IsNaN(newTriangle.Area) 
                      || double.IsInfinity(newTriangle.Area)
                      || !(num1 + num2 > num3)
                      || !(num1 + num3 > num2)
                      || !(num2 + num3 > num1)
                    )
                    {
                        Console.WriteLine("Error, the sides you entered are not valid. Please ensure the sum of 2 sides are greater then or the same as the third.");
                        isValidTriangleInputs = false;
                    } 

                }
            } while (!isValidTriangleInputs);
            newTriangle = new Triangle(num1,num2,num3, "Triangle", 3);
            Console.WriteLine($"The triangle has side lengths {newTriangle.Side1Length}, {newTriangle.Side2Length}, and {newTriangle.Side1Length}.  Its area is {newTriangle.Area} and its perimeter is {newTriangle.Perimeter}.");

            // Circle Section
            do
            {
                Console.WriteLine("\nCircle Section!\n");
                Console.Write("Enter the radius: ");
                userInput = Console.ReadLine().Trim();
            } while (!IsValidResponse(userInput, "Circle"));
            Circle newCircle = new Circle(double.Parse(userInput), "Circle", 0);
            Console.WriteLine($"The circle has a radius of {newCircle.Radius}. The area is {newCircle.Area} and the perimeter is {newCircle.Perimeter}.");

            // Rectangle Section
            do
            {
                Console.WriteLine("\nRectangle Section!\n");
                Console.Write("Enter a length and a width: ");
                userInput = Console.ReadLine().Trim();
            } while (!IsValidResponse(userInput, "Rectangle"));
            string[] inputs = userInput.Split(' ');
            Rectangle newRectangle = new Rectangle(double.Parse(inputs[0]), double.Parse(inputs[1]), "Rectangle", 4);
            Console.WriteLine($"The the Length you entered is {newRectangle.Length} and the width you entered is {newRectangle.Width}. The area is {newRectangle.Area} and the perimeter is {newRectangle.Perimeter}");
        }
        private static bool IsValidResponse(string input, string validationContext)
        {
            double num1 = -1;
            double num2 = -1;
            double num3 = -1;
            bool isValid = false;
            if (validationContext == "Square" || validationContext == "Circle")
            {
                if (!string.IsNullOrEmpty(input))
                {
                    isValid = double.TryParse(input, out num1);
                    if (num1 <= 0)
                    {
                        isValid = false;
                    }
                    else
                    {
                        isValid = true;
                    }
                }
                if (!isValid)
                {
                    Console.WriteLine("Invalid Input. Please enter a valid positive number.");
                }
            } else if (validationContext == "Triangle") {
                if (!string.IsNullOrEmpty(input))
                {
                    string[] inputs = input.Split(' ');
                    if (inputs.Length == 3)
                    {
                        isValid = double.TryParse(inputs[0], out num1);
                        isValid = double.TryParse(inputs[1], out num2);
                        isValid = double.TryParse(inputs[2], out num3);
                        if (num1 <= 0 || num2 <= 0 || num3 <= 0)
                        {
                            isValid = false;
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                }
                if (!isValid)
                {
                    Console.WriteLine("Invalid Input. Please enter three positive numbers seperated by a space.");
                }
            } else if (validationContext == "Rectangle")
            {
                if (!string.IsNullOrEmpty(input))
                {
                    string[] inputs = input.Split(' ');
                    if (inputs.Length == 2)
                    {
                        isValid = double.TryParse(inputs[0], out num1);
                        isValid = double.TryParse(inputs[1], out num2);
                        if (num1 <= 0 || num2 <= 0)
                        {
                            isValid = false;
                        } else
                        {
                            isValid = true;
                        }
                    }
                }
                if (!isValid)
                {
                    Console.WriteLine("Invalid Input. Please enter two positive numbers seperated by a space.");
                }
            }
            return isValid;
        }
        private static bool ContinuGame(string input)
        {
            bool continueGame = false;
            bool inputValid = false;
            string userInput;
            do
            {
               Console.Write(input);
               userInput = Console.ReadLine().ToLower().Trim();
               switch (userInput)
                {
                    case "y":
                    case "yes":
                        continueGame = true;
                        inputValid = true;
                        break;
                    case "n":
                    case "no":
                        inputValid = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please enter 'yes', 'y', 'no', or 'n'.");
                        inputValid = false;
                        break;

                }
            } while (!inputValid);
            if (!continueGame)
            {
                Console.WriteLine("Goodbye!");
            }
            return continueGame;
        }
    }
}
