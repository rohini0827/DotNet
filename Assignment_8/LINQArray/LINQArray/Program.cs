// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Define an integer array
        int[] numbers = { 10, 25, 30, 45, 50, 60, 75, 85, 95, 100 };

        Console.WriteLine("Original Array:");
        Console.WriteLine(string.Join(", ", numbers));

        // Step 2: Use LINQ query to get even numbers
        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        Console.WriteLine("\nEven Numbers using LINQ:");
        Console.WriteLine(string.Join(", ", evenNumbers));

        // Step 3: Use LINQ method syntax to get numbers greater than 50
        var greaterThan50 = numbers.Where(n => n > 50).ToArray();

        Console.WriteLine("\nNumbers greater than 50:");
        Console.WriteLine(string.Join(", ", greaterThan50));

        // Step 4: Find the sum of all numbers using LINQ
        int sum = numbers.Sum();
        Console.WriteLine("\nSum of all numbers: " + sum);

        // Step 5: Order numbers in ascending order using LINQ
        var sortedNumbers = numbers.OrderBy(n => n).ToArray();

        Console.WriteLine("\nSorted Numbers:");
        Console.WriteLine(string.Join(", ", sortedNumbers));

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
