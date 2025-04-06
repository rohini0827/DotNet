// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.IO;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nMenu-Driven File Operations:");
            Console.WriteLine("1. Read, Write & Append Text File");
            Console.WriteLine("2. Read & Write Binary File");
            Console.WriteLine("3. Get File & Directory Information");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    TextFileOperations();
                    break;
                case "2":
                    BinaryFileOperations();
                    break;
                case "3":
                    GetFileAndDirectoryInfo();
                    break;
                case "4":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please enter a valid option.");
                    break;
            }
        }
    }

    
    static void TextFileOperations()
    {
        string filePath = "sample.txt";

        Console.WriteLine("\nText File Operations:");
        Console.WriteLine("a. Write to File");
        Console.WriteLine("b. Append to File");
        Console.WriteLine("c. Read from File");
        Console.Write("Enter choice: ");
        string option = Console.ReadLine().ToLower();

        try
        {
            if (option == "a")
            {
                Console.Write("Enter text to write: ");
                string text = Console.ReadLine();
                File.WriteAllText(filePath, text);
                Console.WriteLine("File written successfully.");
            }
            else if (option == "b")
            {
                Console.Write("Enter text to append: ");
                string text = Console.ReadLine();
                File.AppendAllText(filePath, text + Environment.NewLine);
                Console.WriteLine("Text appended successfully.");
            }
            else if (option == "c")
            {
                if (File.Exists(filePath))
                {
                    string content = File.ReadAllText(filePath);
                    Console.WriteLine("File Content:\n" + content);
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    
    static void BinaryFileOperations()
    {
        string filePath = "binaryData.dat";

        Console.WriteLine("\nBinary File Operations:");
        Console.WriteLine("a. Write to Binary File");
        Console.WriteLine("b. Read from Binary File");
        Console.Write("Enter choice: ");
        string option = Console.ReadLine().ToLower();

        try
        {
            if (option == "a")
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
                {
                    Console.Write("Enter an integer to write: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    writer.Write(num);
                    Console.WriteLine("Binary file written successfully.");
                }
            }
            else if (option == "b")
            {
                if (File.Exists(filePath))
                {
                    using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                    {
                        int num = reader.ReadInt32();
                        Console.WriteLine("Read from binary file: " + num);
                    }
                }
                else
                {
                    Console.WriteLine("Binary file does not exist.");
                }
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }


    static void GetFileAndDirectoryInfo()
    {
        Console.Write("\nEnter directory path: ");
        string path = Console.ReadLine();

        if (Directory.Exists(path))
        {
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            Console.WriteLine($"Directory Name: {dirInfo.Name}");
            Console.WriteLine($"Full Path: {dirInfo.FullName}");
            Console.WriteLine($"Created On: {dirInfo.CreationTime}");

            Console.WriteLine("\nFiles in the directory:");
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine($"- {file.Name}, Size: {file.Length} bytes, Created: {file.CreationTime}");
            }
        }
        else
        {
            Console.WriteLine("Directory does not exist.");
        }
    }
}
