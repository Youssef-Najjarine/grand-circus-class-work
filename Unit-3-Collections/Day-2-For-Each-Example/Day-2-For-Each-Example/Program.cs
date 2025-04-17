namespace Day_2_For_Each_Example;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to an Example of a For-Each Loop");
        // Ask the user to enter a sentence (series of words seperated by whitespace - space, tab, something you can't see)
        // Display each word in the sentence

        Console.WriteLine("Please enter a sentence");
        string sentence = Console.ReadLine(); // Get what type and put it in a string

        string[] splitSentence = sentence.Split(" "); // split the sentence into words

        for (int i = 0; i < splitSentence.Length;i++)
        {
            Console.WriteLine(splitSentence[i]);
        }
    }
}