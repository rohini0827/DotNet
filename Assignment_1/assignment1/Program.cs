// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using assignment1.pr4ograms;


namespace assignment1
{
    class Program
    {
        static void Main()
        {
            while (true) // Keep running until user chooses to exit
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Shuffle String");
                Console.WriteLine("2. Sum of Digits");
                Console.WriteLine("3. Palindrome Check");
                Console.WriteLine("4. Square Root Calculation");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice)) // Validate input
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ShuffleString.Run();
                        break;
                    case 2:
                        SumOfDigits.Run();
                        break;
                    case 3:
                        Palindrome.Run();
                        break;
                    case 4:
                        SquareRoot.Run();
                        break;
                    case 5:
                        Console.WriteLine("Exiting program. Goodbye, Have a nice day!");
                        return; // Exit the program
                    default:
                        Console.WriteLine("Invalid choice! Please enter a valid option.");
                        break;
                }
            }
        }
    }
}