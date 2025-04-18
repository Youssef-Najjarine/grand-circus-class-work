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
                bool validEntry = false;
                string itemName = "";
                decimal price = 0;
                foreach (KeyValuePair<string, decimal> entry in menu)
                {
                    string[] possibleAnswers = entry.Key.Split(".");
                    if (new[] { 
                        entry.Key.ToLower().Trim(), 
                        possibleAnswers[0].Trim(), 
                        possibleAnswers[1].ToLower().Trim() 
                    }.Contains(userInput))
                    {
                        validEntry = true;
                        itemName = possibleAnswers[1].ToLower().Trim();
                        price = entry.Value;
                    }
                }
                if (validEntry)
                {
                    DisplayItemAdded(itemName, price);
                } else
                {
                    Console.WriteLine("Error, That menu item does not exist.");
                    continueOrdering = ContinueOrder("Would you like to try again and continue ordering? (y/n): ");
                    continue;
                }
                shoppingList.Add(new {name = itemName, price = price });
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
        private static void DisplayItemAdded(string itemName, decimal price)
        {
            Console.WriteLine("\nItem added to Shopping List");
            Console.WriteLine("_______________________________");
            Console.WriteLine($"| {"Item",-15} | {"Price",8} |");
            Console.WriteLine("|----------------------------|");
            Console.WriteLine($"| {itemName,-15} | {price,8:C} |");
            Console.WriteLine("------------------------------");
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
            DisplayLeastAndExpensiveItems(shoppingList);
        }
        private static void DisplayLeastAndExpensiveItems(List<dynamic> shoppingList)
        {
            Console.WriteLine("\nMost and Least Items Ordered");
            Console.WriteLine("_______________________________");
            Console.WriteLine($"| {"Item",-15} | {"Price",8} |");
            Console.WriteLine("|----------------------------|");
            Console.WriteLine($"| {shoppingList[0].name,-15} | {shoppingList[0].price,8:C} |");
            Console.WriteLine($"| {shoppingList[shoppingList.Count - 1].name,-15} | {shoppingList[shoppingList.Count - 1].price,8:C} |");
            Console.WriteLine("------------------------------");
        }
    }
}
