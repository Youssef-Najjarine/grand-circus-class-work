namespace _03_Do_While_Loop_Keypad_Entry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userResponse = "";
            int userNumber = 0;
            bool validNumber = false;
            bool doorLocked = true;
            int correctCode = 13579;
            int maxAttempts = 5;
            int attempts = 0;
            bool accessGranted = KeyPadEntryGame(userResponse, userNumber, validNumber, doorLocked, correctCode, maxAttempts, attempts);

            if (accessGranted)
            {
                Console.WriteLine("Correct code entered. Welcome!");
            } else
            {
                Console.WriteLine("Warning, too many attempts. The door is now locked.");
            }
            //do
            //{
            //    do
            //    {
            //        Console.Write("Please enter a key code: ");
            //        userResponse = Console.ReadLine().Trim();
            //        validNumber = int.TryParse(userResponse, out userNumber);
            //        if (!validNumber)
            //        {
            //            Console.WriteLine("Invalid Entry. Please enter a number.");
            //        }
            //    } while (!validNumber);
            //    if (userNumber == correctCode)
            //    {
            //        Console.WriteLine("Correct code entered. Welcome!");
            //        doorLocked = false;
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Incorect code entered.");
            //        attempts++;
            //    }
            //    if (attempts >= maxAttempts)
            //    {
            //        Console.WriteLine("Warning, too many attempts. The door is now locked.");
            //    }
            //} while (doorLocked && attempts < maxAttempts);
        }
        private static bool KeyPadEntryGame(string userResponse, int userNumber, bool validNumber, bool doorLocked, int correctCode, int maxAttempts, int attempts)
        {
            do
            {
                do
                {
                    Console.Write("Please enter a key code: ");
                    userResponse = Console.ReadLine().Trim();
                    validNumber = int.TryParse(userResponse, out userNumber);
                    if (!validNumber)
                    {
                        Console.WriteLine("Invalid Entry. Please enter a number.");
                    }
                } while (!validNumber);
                if (userNumber == correctCode)
                {
                    return true;
                    //doorLocked = false;
                    //break;
                }
                else
                {
                    Console.WriteLine("Incorect code entered.");
                    attempts++;
                }
                if (attempts >= maxAttempts)
                {
                    return false;
                }
            } while (doorLocked && attempts < maxAttempts);
            return false;
        }
    }
}
