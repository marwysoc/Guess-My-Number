using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Run getAppInfo function. Get info about author, version etc.
            getAppInfo();

            // Run greetUser function. Ask for users name and say hello.
            greetUser();

            while (true)
            {
                // Create a new random object.
                Random random = new Random();

                // Init correct number using random. Number from 1 to 10.
                int correctNumber = random.Next(1, 10);

                // Init guess variable.
                int guess = 0;

                // Ask user to guess the number. 
                Console.WriteLine("Guess the number between 1-10: ");

                // Keep asking user for number while the guess isn't correct
                while (guess != correctNumber)
                {
                    // Get users input.
                    string inputNumber = Console.ReadLine();

                    // Make sure it is a number.
                    if (!int.TryParse(inputNumber, out guess))
                    {
                        // Print error message.
                        printColorMsg(ConsoleColor.Red, "Enter a number!");

                        // Keep going.
                        continue;
                    }

                    // Cast to int and put in guess variable.
                    guess = Int32.Parse(inputNumber);

                    // Match guess to correct number.
                    if (guess != correctNumber)
                    {
                        // Print error message. Tell user it is the wrong number.
                        printColorMsg(ConsoleColor.Red, "Wrong number :( Try again");
                    }
                }

                // Print success message. Tell user the number is correct.
                printColorMsg(ConsoleColor.Green, "Correct! Congrats :)");

                // Ask user to play again.
                Console.WriteLine("Do you want to play again? [Y/N]");

                // Get answer.
                string answer = Console.ReadLine().ToUpper();

                // Check users answer.
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }

        }

        // Get and display app info.
        static void getAppInfo()
        {
            // Set app variables.
            string appName = "Guess my number";
            string appVersion = "1.0.0";
            string appAuthor = "Marta Wysocka";

            // Change text color.
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            // Write out app info. Use placeholders.
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color (back to default).
            Console.ResetColor();
        }

        // Ask for users name.
        static void greetUser()
        {
            // Ask users name.
            Console.WriteLine("What's your name?");

            // Get user input.
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}! Let's play a game!", inputName);
        }

        // Print color message
        static void printColorMsg(ConsoleColor color, string msg)
        {
            // Change text color.
            Console.ForegroundColor = color;

            // Print a message.
            Console.WriteLine(msg);

            // Reset text color (back to default).
            Console.ResetColor();
        }
    }
}
