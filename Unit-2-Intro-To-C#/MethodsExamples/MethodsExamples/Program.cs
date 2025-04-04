namespace MethodsExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mySum = Addem(4, 5);
            Console.WriteLine("The sum of 4 and 5 is: " + mySum);
        }
        static int Addem(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
