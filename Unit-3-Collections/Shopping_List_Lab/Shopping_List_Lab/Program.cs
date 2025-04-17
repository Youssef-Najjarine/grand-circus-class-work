namespace Shopping_List_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> menu = new Dictionary<string, decimal>() {
                {"1. apple",1},
                {"2. filet mignon",88.75m},
                {"3. milk",3.99m},
                {"4. bread",2.49m},
                {"5. eggs",4.99m},
                {"6. potatoes",5.99m},
                {"7. chicken",12.99m},
                {"8. cheese",6.99m},
                {"9. ice cream",4.49m},
                {"10. pizza",9}
            };
            List<dynamic> shoppingList = new List<dynamic>();
            bool continueOrdering = true;
            do
            {
                PrintMenu(menu);
                Console.Write("\nPlease enter a shopping list item: ");
                string userInput = Console.ReadLine().ToLower().Trim();
                string[] possibleAnswers = userInput.Split(".");
                foreach (string a in possibleAnswers)
                {
                    Console.WriteLine($"a:{a}");
                }
                if (menu.ContainsKey(userInput))
                {
                    Console.WriteLine($"You added {userInput}: ${menu[userInput]} to your shopping list.");
                } else
                {
                    Console.WriteLine("Error, That menu item does not exist.");
                    continueOrdering = ContinueOrder("Would you like to try again and continue ordering? (y/n): ");
                    continue;
                }
                shoppingList.Add(new {name = userInput,price = menu[userInput]});
                continueOrdering = ContinueOrder("Would you like to add another item? (y/n): ");
            } while (continueOrdering);
            if (shoppingList.Count > 0)
            {
                shoppingList.Sort((x, y) => x.price.CompareTo(y.price));
                PrintShoppingListAndSum(shoppingList);
            }
        }

        private static void PrintMenu(Dictionary<string, decimal> menu)
        {
            Console.WriteLine("\nMENU:");
            Console.WriteLine("_______________________________");
            Console.WriteLine($"| {"Item",-15} | {"Price",8} |");
            Console.WriteLine("|----------------------------|");
            foreach (KeyValuePair<string, decimal> entry in menu)
            {
                Console.WriteLine($"| {entry.Key,-15} | {entry.Value,8:C} |");
            }
            Console.WriteLine("------------------------------");
        }
        private static bool ContinueOrder(string message)
        {
            bool validInput = false;
            bool continueOrder = false;
            string userInput;
            do
            {
                Console.Write(message);
                userInput = Console.ReadLine().ToLower().Trim();
                if (!((string[]) ["y","n", "yes", "no"]).Contains(userInput))
                {
                    Console.WriteLine("Invalid input. Please enter 'y', 'n', 'yes', or 'no'.");
                    continue;
                } else
                {
                    validInput = true;
                }
            } while (!validInput);
            if (new[] {"y", "yes"}.Contains(userInput))
            {
                continueOrder = true;
            } else
            {
                continueOrder = false;
            }
                return continueOrder;
        }
        private static void PrintShoppingListAndSum(List<dynamic> shoppingList)
        {
            decimal sum = 0;
            
            Console.WriteLine("\nShopping List");
            Console.WriteLine("_______________________________");
            Console.WriteLine($"| {"Item",-15} | {"Price",8} |");
            Console.WriteLine("|----------------------------|");
            foreach (dynamic item in shoppingList)
            {
                sum += item.price;
                Console.WriteLine($"| {item.name,-15} | {item.price,8:C} |");
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"\nThe sum of your shopping list is: {sum:C}");
        }
    }
}
