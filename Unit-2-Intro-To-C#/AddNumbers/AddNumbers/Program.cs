namespace AddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entry = 0;
            int sum = 0;
            for (int i = 0; i < 3;i++)
            {
                Console.WriteLine("Please enter a number: ");
                entry = int.Parse(Console.ReadLine());
                sum += entry;
            }
            Console.WriteLine($"The sum is {sum}");

        }
    }
}
