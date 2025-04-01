namespace _01_Exercises__Variables_and_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE 1.1: Echo String
            Console.WriteLine("EXERCISE 1.1: Echo String\n");

            Console.Write("Enter some text: ");
            string userResponse = Console.ReadLine();
            Console.WriteLine($"{userResponse}\n");

            // EXERCISE 1.2: Adding a number to an integer
            Console.WriteLine("EXERCISE 1.2: Adding a number to an integer\n");

            Console.Write("Enter a number: ");
            userResponse = Console.ReadLine();
            int integerNumber = int.Parse(userResponse);
            int integerSum = integerNumber + 1;
            Console.WriteLine($"{integerSum}\n");

            // EXERCISE 1.3: Adding a number to a float
            Console.WriteLine("EXERCISE 1.3: Adding a number to a float\n");

            Console.Write("Enter a number: ");
            userResponse = Console.ReadLine();
            float floatNumber = float.Parse(userResponse);
            float floatSum = floatNumber + .5F;
            Console.WriteLine($"{floatSum}\n");

            // EXERCISE 1.4: Adding Two Floats
            Console.WriteLine("EXERCISE 1.4: Adding Two Floats\n");

            floatSum = 0;
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.Write("Enter a number: ");
                } else 
                {
                    Console.Write("Enter another number: ");
                }
                userResponse = Console.ReadLine();
                floatNumber = float.Parse(userResponse);
                floatSum += floatNumber;
            }
            Console.WriteLine($"The sum is {floatSum}\n");

            // EXERCISE 1.5: Multiplying Floats
            Console.WriteLine("EXERCISE 1.5: Multiplying Floats\n");

            float floatProduct = 0;
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.Write("Enter a number: ");
                } else 
                {
                    Console.Write("Enter another number: ");
                }
                userResponse = Console.ReadLine();
                floatNumber = float.Parse(userResponse);
                if (i == 0)
                {
                    floatProduct = floatNumber;
                } else
                {
                    floatProduct *= floatNumber;
                }
            }
            Console.WriteLine($"The product is {floatProduct}\n");

            // EXERCISE 1.6: Dividing Integers
            Console.WriteLine("EXERCISE 1.6: Dividing Integers\n");

            int quotient = 0;
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    Console.Write("Enter a number: ");
                } else
                {
                    Console.Write("Enter another number: ");
                }
                userResponse = Console.ReadLine();
                integerNumber = int.Parse(userResponse);
                if (i == 0)
                {
                    quotient = integerNumber;
                } else
                {
                    quotient /= integerNumber;
                }
            }
            Console.WriteLine($"The result is {quotient}\n");
            // If you try to divide two integers that aren't evenly divisible you will get a truncated result that is not accurate. To resolve this use float types or type casting.
            // If you try to enter decimal numbers you will get a FormatException error because it expects a type of integer to be used. To resolve this use decimal types or type casting.

            // EXERCISE 1.7: Entering booleans
            Console.WriteLine("EXERCISE 1.7: Entering booleans\n");

            Console.Write("Enter a boolean: ");

            userResponse = Console.ReadLine();
            bool booleanValue = bool.Parse(userResponse);
            Console.WriteLine($"You entered: {booleanValue}");
            Console.WriteLine($"The opposite of what you entered is: {!booleanValue}");
            // The only 2 valid user inputs for booleans are "true" and "false". They are not case-sensitive.
            // True or False will get displayed on the screen with an uppercase first letter when you WriteLine a boolean value.
        }
    }
}
