using System.Drawing;
using System.Xml.Linq;

namespace Abstract_and_Base_Classes_53_56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //Console.WriteLine("\nEXERCISE 54\n");
                //Exercise54();

                //Console.WriteLine("\nEXERCISE 55\n");
                //Exercise55();

                Console.WriteLine("\nEXERCISE 56\n");
                Exercise56();
            } while (ContinuGame("Would you like to continue (y/n)? "));
        }
        private static void Exercise54()
        {
            string userInput;
            double num1 = - 1;
            double num2 = -1;
            double num3 = -1;
            double num4 = -1;
            double num5 = -1;

            // Square Section
            do
            {
                Console.WriteLine("\nSquare Section!\n");
                Console.Write("Enter a side length: ");
                userInput = Console.ReadLine().Trim();
            } while (!IsValidResponse(userInput, "Square"));
            Square newSquare = new Square(double.Parse(userInput), "Square", 4);
            Console.WriteLine(newSquare.ToString());

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
            newTriangle = new Triangle(num1, num2, num3, "Triangle", 3);
            Console.WriteLine(newTriangle.ToString());

            // Circle Section
            do
            {
                Console.WriteLine("\nCircle Section!\n");
                Console.Write("Enter the radius: ");
                userInput = Console.ReadLine().Trim();
            } while (!IsValidResponse(userInput, "Circle"));
            Circle newCircle = new Circle(double.Parse(userInput), "Circle", 0);
            Console.WriteLine(newCircle.ToString());

            // Rectangle Section
            do
            {
                Console.WriteLine("\nRectangle Section!\n");
                Console.Write("Enter a length and a width: ");
                userInput = Console.ReadLine().Trim();
            } while (!IsValidResponse(userInput, "Rectangle"));
            string[] inputs = userInput.Split(' ');
            Rectangle newRectangle = new Rectangle(double.Parse(inputs[0]), double.Parse(inputs[1]), "Rectangle", 4);
            Console.WriteLine(newRectangle.ToString());

            // Pentagon Section
            do
            {
                Console.WriteLine("\nPentagon Section\n");
                Console.Write("Enter the side lengths of a pentagon: ");
                userInput = Console.ReadLine().Trim();
            } while (!IsValidResponse(userInput, "Pentagon"));
            string[] pentagonInputs = userInput.Split(' ');
            num1 = double.Parse(pentagonInputs[0]);
            num2 = double.Parse(pentagonInputs[1]);
            num3 = double.Parse(pentagonInputs[2]);
            num4 = double.Parse(pentagonInputs[3]);
            num5 = double.Parse(pentagonInputs[4]);
            Pentagon newPentagon = new Pentagon(num1, num2, num3, num4, num5, "Pentagon", 5);
            Console.WriteLine(newPentagon.ToString());
        }
       private static void Exercise55()
        {
            Dog aDog = new Dog("Pebbles", "dog",42, "black","house","steak",3.5);
            Console.WriteLine(aDog.ToString());
            Whale aWhale = new Whale("Floaty", "blue whale", 85, "blue", "ocean", "zooplankton ", 300000);
            Console.WriteLine("\n" + aWhale.ToString() + "\n");
        }
        private static void Exercise56()
        {
            int studentNumberEntered = -1;
            string userInput;
            bool notValid = true;
            Student[] students = InitializeStudents();
            do
            {
                DisplayStudentSelection(students);
                Console.Write($"Welcome! Which student would you like to learn more about? Enter a number 1 - {students.Length} or enter a student's name: ");
                userInput = Console.ReadLine().ToLower().Trim();
                notValid = Int32.TryParse(userInput, out studentNumberEntered);
                notValid = (studentNumberEntered < 1) || (studentNumberEntered > students.Length);
                if (notValid)
                {
                    for (int i = 0; i < students.Length; i++)
                    {
                        string[] splitStudentName = students[i].Name.ToLower().Split(' ');
                        if (students[i].Name.ToLower() == userInput || splitStudentName[0] == userInput || splitStudentName[1] == userInput)
                        {
                            notValid = false;
                            studentNumberEntered = i;
                            break;
                        }
                    }
                } else
                {
                    studentNumberEntered = studentNumberEntered - 1;
                }
                if (notValid)
                {
                    Console.WriteLine($"Invalid Input. Please enter a number that's between 1 and {students.Length} inclusive or enter a student's name.");
                }
            } while (notValid);
            do
            {
                Console.Write($"Student {studentNumberEntered + 1} is {students[studentNumberEntered].Name}. What would you like to know? Enter 'hometown' or 'favorite food': ");
                userInput = Console.ReadLine().ToLower().Trim();
                if (!(new string[] { "hometown", "home", "town", "favorite food", "food" }).Contains(userInput))
                {
                    Console.WriteLine("That category does not exist. Please try again. Enter \"hometown\" or \"favorite food\".");
                }
            } while (!((string[])["hometown", "home", "town", "favorite food", "food"]).Contains(userInput));
            if (((string[])["hometown", "home", "town"]).Contains(userInput))
            {
                Console.WriteLine($"{students[studentNumberEntered].Name} is from {students[studentNumberEntered].HomeTown}");
            } else
            {
                Console.WriteLine($"{students[studentNumberEntered].Name}'s favorite food is {students[studentNumberEntered].FavoriteFood}");
            }
        }
        private static Student[] InitializeStudents() {
            Student[] students = new Student[] {
                new Student("Timmy Mike", "Seattle, Washington", "Mac & Cheese"),
                new Student("Sally ErmenTrout", "Portland, Oregon", "Pizza"),
                new Student("Billy Mitchel", "San Francisco, California", "Tacos"),
                new Student("Mary Poppins", "Los Angeles, California", "Sushi"),
                new Student("John Doe", "Denver, Colorado", "Burgers"),
                new Student("Jane Queen", "Austin, Texas", "Brisket"),
                new Student("Tom Heartford", "Miami, Florida", "Pasta"),
                new Student("Jerry Tom", "New York, New York", "Pizza"),
                new Student("Bob Dylan", "Chicago, Illinois", "Steak"),
                new Student("Alice Cassand", "Boston, Massachusetts", "Seafood")
            };
            return students;
        }
        private static void DisplayStudentSelection(Student[] students)
        {
            Console.WriteLine("\nStudents:");
            Console.WriteLine("-----------------------");
            Console.WriteLine($"| {"#"} | {"Student",-16}|");
            Console.WriteLine("-----------------------");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"| {i + 1} | {students[i].Name,-16}|");
            }

            Console.WriteLine("-----------------------");
        }
        private static bool IsValidResponse(string input, string validationContext)
        {
            double num1 = -1;
            double num2 = -1;
            double num3 = -1;
            double num4 = -1;
            double num5 = -1;
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
            } else if (validationContext == "Pentagon")
            {
                if (!string.IsNullOrEmpty(input))
                {
                    string[] inputs = input.Split(' ');
                    if (inputs.Length == 5)
                    {
                        isValid = double.TryParse(inputs[0], out num1);
                        isValid = double.TryParse(inputs[1], out num2);
                        isValid = double.TryParse(inputs[2], out num3);
                        isValid = double.TryParse(inputs[3], out num4);
                        isValid = double.TryParse(inputs[4], out num5);
                        if (num1 <= 0 || num2 <= 0 || num3 <= 0 || num4 <= 0 || num5 <= 0)
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
                    Console.WriteLine("Invalid Input. Please enter five positive numbers seperated by a space.");
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
