// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Create a collection of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 101, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { ID = 102, Name = "Bob", Department = "IT", Salary = 80000 },
            new Employee { ID = 103, Name = "Charlie", Department = "Finance", Salary = 60000 },
            new Employee { ID = 104, Name = "David", Department = "IT", Salary = 75000 },
            new Employee { ID = 105, Name = "Eve", Department = "HR", Salary = 48000 }
        };

        // Step 2: Display all employees
        Console.WriteLine("All Employees:");
        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        }

        // Step 3: Filter employees with Salary > 50,000
        var highSalaryEmployees = from emp in employees
                                  where emp.Salary > 50000
                                  select emp;

        Console.WriteLine("\nEmployees with Salary > 50,000:");
        foreach (var emp in highSalaryEmployees)
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Salary: {emp.Salary}");
        }

        // Step 4: Sort employees by Name
        var sortedEmployees = from emp in employees
                              orderby emp.Name
                              select emp;

        Console.WriteLine("\nEmployees Sorted by Name:");
        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
        }

        // Step 5: Group employees by Department
        var groupedEmployees = from emp in employees
                               group emp by emp.Department into deptGroup
                               select new { Department = deptGroup.Key, Employees = deptGroup };

        Console.WriteLine("\nEmployees Grouped by Department:");
        foreach (var group in groupedEmployees)
        {
            Console.WriteLine($"Department: {group.Department}");
            foreach (var emp in group.Employees)
            {
                Console.WriteLine($"  ID: {emp.ID}, Name: {emp.Name}, Salary: {emp.Salary}");
            }
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

// Employee class
class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Salary { get; set; }
}
