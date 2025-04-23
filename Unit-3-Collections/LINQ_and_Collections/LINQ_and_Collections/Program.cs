using System.Globalization;

namespace LINQ_and_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 12, 99, 42, 949, 100000, 3764, 2942, 523863, 999999 };
            int min = nums.Min();
            int max = nums.Max();
            int maxVallessThan10000 = nums.Where(num => num < 10000).Max();
            List<int> valsBetween10And100 = nums.Where(num => num > 10 && num < 100).ToList();
            string displayString = string.Join(", ", valsBetween10And100);
            List<int> valsBetween100000And999999Inclusive = nums.Where(num => num >= 100000 && num <= 999999).ToList();
            string displayString2 = string.Join(", ", valsBetween100000And999999Inclusive);
            int evenCount = nums.Count(num => num % 2 == 0);

            Console.WriteLine($"The Minimum value is: {min}");
            Console.WriteLine($"The Maximum value is: {max}");
            Console.WriteLine($"The Maximum value less than 10000 is: {maxVallessThan10000}");
            Console.WriteLine($"The values between 10 and 100 are: {displayString}");
            Console.WriteLine($"The values between 100000 and 999999 inclusive are: {displayString2}");
            Console.WriteLine($"The count of even numbers is: {evenCount}");

        }
    }
}
