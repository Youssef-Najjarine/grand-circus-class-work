namespace FirstProgram

    // This program will ask for three numbers

    // add them together and display the total


{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Starting program --");
            Console.Write("Please enter a number: ");
            int num1;
            bool validNum1 = int.TryParse(Console.ReadLine(), out num1);
            if (!validNum1)
                Console.WriteLine("Invalid number entered");

            Console.Write("Please enter a second number: ");
            int num2;
            bool validNum2 = int.TryParse(Console.ReadLine(), out num2);
            if (!validNum2)
                Console.WriteLine("Invalid number entered");

            Console.Write("Please enter a third number: ");
            int num3;
            bool validNum3 = int.TryParse(Console.ReadLine(), out num3);
            if (!validNum3)
                Console.WriteLine("Invalid number entered");

            Console.WriteLine($"The total of the three numbers is: {num1 + num2 + num3}");
            Console.WriteLine("-- Ending program --");
        }
    }
}
