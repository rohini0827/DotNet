// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Create XML using LINQ to XML
        XDocument employeesXml = new XDocument(
            new XElement("Employees",
                new XElement("Employee",
                    new XAttribute("ID", 101),
                    new XElement("Name", "Alice"),
                    new XElement("Department", "HR"),
                    new XElement("Salary", 50000)
                ),
                new XElement("Employee",
                    new XAttribute("ID", 102),
                    new XElement("Name", "Bob"),
                    new XElement("Department", "IT"),
                    new XElement("Salary", 80000)
                ),
                new XElement("Employee",
                    new XAttribute("ID", 103),
                    new XElement("Name", "Charlie"),
                    new XElement("Department", "Finance"),
                    new XElement("Salary", 60000)
                )
            )
        );

        // Step 2: Save XML to a file
        string filePath = "employees.xml";
        employeesXml.Save(filePath);
        Console.WriteLine($"XML file saved at: {filePath}");

        // Step 3: Load XML from file
        XDocument loadedXml = XDocument.Load(filePath);

        // Step 4: Query XML - Retrieve employees in IT department
        var itEmployees = from emp in loadedXml.Descendants("Employee")
                          where emp.Element("Department")?.Value == "IT"
                          select new
                          {
                              ID = emp.Attribute("ID")?.Value,
                              Name = emp.Element("Name")?.Value,
                              Salary = emp.Element("Salary")?.Value
                          };

        Console.WriteLine("\nEmployees in IT Department:");
        foreach (var emp in itEmployees)
        {
            Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Salary: {emp.Salary}");
        }

        // Step 5: Query XML - Retrieve employees with salary > 50,000
        var highSalaryEmployees = from emp in loadedXml.Descendants("Employee")
                                  where int.Parse(emp.Element("Salary")?.Value ?? "0") > 50000
                                  select emp;

        Console.WriteLine("\nEmployees with Salary > 50,000:");
        foreach (var emp in highSalaryEmployees)
        {
            Console.WriteLine($"ID: {emp.Attribute("ID")?.Value}, Name: {emp.Element("Name")?.Value}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}

