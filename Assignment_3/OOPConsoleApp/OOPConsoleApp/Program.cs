// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;

namespace OOPConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(HR);

            HR.DisplayMessage();

            Employee emp1 = new Employee("Alice", 101, 50000);
            Manager mgr1 = new Manager("Bob", 102, 80000, "IT");
            Intern intern1 = new Intern("Charlie", 103, 10000, 6);

            Console.WriteLine("\n--- Employee Details ---");
            emp1.ShowDetails();

            Console.WriteLine("\n--- Manager Details (Override Example) ---");
            mgr1.ShowDetails();

            Console.WriteLine("\n--- Intern Details (new Keyword Example) ---");
            intern1.ShowDetails();

            
            //HR.DisplayMessage();

            Console.ReadLine();
        }
    }
}
