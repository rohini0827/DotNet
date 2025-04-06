// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//using System;
//using MyOperations;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            Console.WriteLine(MyOperations.SafeDivide(10, 0));
//        }
//        catch (MyCustomException ex)
//        {
//            Console.WriteLine($"Custom Exception Caught: Code {ex.ErrorCode}, Message: {ex.Message}");
//        }

//        try
//        {
//            int[] numbers = { 1, 2, 3 };
//            Console.WriteLine(MyOperations.GetArrayElement(numbers, 5));
//        }
//        catch (MyCustomException ex)
//        {
//            Console.WriteLine($"Custom Exception Caught: Code {ex.ErrorCode}, Message: {ex.Message}");
//        }
//    }
//}


using System;
using MyOperations; // Import the namespace of MyOperations class

class Program
{
    static void Main()
    {
        Console.WriteLine("Console-Based Application for MyOperations\n");

        try
        {
            Console.WriteLine("Testing Division Operation:");
            int result = MyOperations.SafeDivide(10, 0); // Will throw MyCustomException
            Console.WriteLine("Result: " + result);
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Custom Exception Caught: Code {ex.ErrorCode}, Message: {ex.Message}");
        }

        try
        {
            Console.WriteLine("\nTesting Array Element Access:");
            int[] numbers = { 5, 10, 15 };
            int value = MyOperations.GetArrayElement(numbers, 5); // Will throw MyCustomException
            Console.WriteLine("Value at index: " + value);
        }
        catch (MyCustomException ex)
        {
            Console.WriteLine($"Custom Exception Caught: Code {ex.ErrorCode}, Message: {ex.Message}");
        }

        Console.WriteLine("\nProgram execution completed.");
    }
}
