using System;

namespace Lab3_decisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            string userChoice = "y";

            // prompt user
            Console.WriteLine("Before we get started, what's your name? ");
            string userName = Console.ReadLine();
            Console.WriteLine($"\nYo {userName}!");
            
            // processing + outputting 
            while (userChoice != "n")
            {
                Console.WriteLine("\nEnter a number between 1 and 100");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput <= 0 || userInput > 100)
                {
                    Console.WriteLine($"\n{userInput} is out of range {userName}! ");
                    continue;
                }
                else if (userInput % 2 == 0 && userInput >= 2 && userInput <= 25)
                {
                    Console.WriteLine("\nEven and less than 25. ");
                }
                else if (userInput % 2 == 0 && userInput >= 26 && userInput <= 60)
                {
                    Console.WriteLine("\nEven.");
                }
                else if (userInput % 2 == 0 && userInput > 60)
                {
                    Console.WriteLine($"\n{userInput} is Even.");
                }
                else if (userInput > 60)
                {
                    Console.WriteLine($"\n{userInput} is Odd.");
                }
                else
                {
                    Console.WriteLine($"\n{userInput} is Odd.\n");
                }
                Console.WriteLine("\nenter 'y' to continue and 'n' ");
                userChoice = Console.ReadLine();
            }
            Console.WriteLine($"\nSee ya later {userName}!");
        }
    }
}
