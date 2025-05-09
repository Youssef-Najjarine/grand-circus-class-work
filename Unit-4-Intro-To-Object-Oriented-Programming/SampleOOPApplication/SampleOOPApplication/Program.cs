using System.Reflection;
using System.Xml.Linq;

namespace SampleOOPApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person aPerson = new Person("John", 78, 250.6, 69, "Male", "Red", "Green");
            Console.WriteLine(aPerson);
        }
    }
}
