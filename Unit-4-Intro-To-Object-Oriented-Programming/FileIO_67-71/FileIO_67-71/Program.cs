namespace FileIO_67_71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nExercise 67!!\n");
            //Exercise67();

            Console.WriteLine("\nExercise 68!!\n");
            Exercise68();

            Console.WriteLine("\nExercise 68!!\n");
            Exercise68();
        }
        private static void Exercise67()
        {
            int total = 0;
            bool continueGame = true;
            string userInput;
            string displayString = "";
            do
            {
                Console.Write("Enter a file to read numbers from: ");
                total = 0;
                displayString = "";
                userInput = Console.ReadLine().ToLower().Trim();
                File.WriteAllText(userInput, "7 12 13 15 12 11");
                List<string> numbers = File.ReadAllText(userInput).Split(" ").ToList();
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i < numbers.Count - 1) displayString += $"{numbers[i]} + ";
                    else displayString += $"{numbers[i]} = ";
                    total += Int32.Parse(numbers[i]);
                }
                displayString += total.ToString();
                Console.WriteLine(displayString);
                Console.Write("Do you want to continue? (y/n): ");
                userInput = Console.ReadLine().ToLower().Trim();
                continueGame = userInput == "y" || userInput == "yes";
            } while (continueGame);
            Console.WriteLine("Goodbye!");
        }
        private static void Exercise68() { 
            bool continueGame = true;
            string userInput;
            do
            {
                Console.Write("Enter a file to read translations from: ");
                userInput = Console.ReadLine().ToLower().Trim();
                File.WriteAllText(userInput, "hello,hola food,comida world,mundo computer,computadora exercise,ejercicio");
                List<string> fileContent = File.ReadAllText(userInput).Split(" ").ToList();
                Dictionary<string, string> translations = new Dictionary<string, string>();
                foreach (string line in fileContent)
                {
                    string[] parts = line.Split(",");
                    translations.Add(parts[0].Trim(), parts[1].Trim());
                }
                Console.Write("Enter a word in English: ");
                userInput = Console.ReadLine().ToLower().Trim();
                if (!translations.ContainsKey(userInput))
                {
                    Console.WriteLine("playing cannot be translated");
                } else
                {
                    foreach (KeyValuePair<string, string> translation in translations)
                    {
                        if (translation.Key.ToLower() == userInput)
                        {
                            Console.WriteLine($"{translation.Key} in Spanish is {translation.Value}");
                        }
                    }
                }
                    Console.Write("Do you want to continue? (y/n): ");
                userInput = Console.ReadLine().ToLower().Trim();
                continueGame = userInput == "y" || userInput == "yes";
            } while (continueGame);
            Console.WriteLine("GoodBye!");
        }
        private static void Exercise69()
        {
            // Not implemented in this example
        }
    }
}
