using System;

namespace OOPConsoleApp
{
    public interface IEmployee
    {
        void ShowDetails();
    }
    public class Employee : IEmployee
    {
        protected string name;
        protected int empID;
        protected double salary;

        public Employee(string name, int empID, double salary)
        {
            this.name = name;
            this.empID = empID;
            this.salary = salary;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"Employee ID: {empID}, Name: {name}, Salary: {salary}");
        }
    }
    public class Manager : Employee
    {
        private string department;

        public Manager(string name, int empID, double salary, string department)
            : base(name, empID, salary)
        {
            this.department = department;
        }
        public override void ShowDetails()
        {
            Console.WriteLine($"Manager ID: {empID}, Name: {name}, Department: {department}, Salary: {salary}");
        }
    }

    public class Intern : Employee
    {
        private int duration;

        public Intern(string name, int empID, double salary, int duration)
            : base(name, empID, salary)
        {
            this.duration = duration;
        }
        public new void ShowDetails()
        {
            Console.WriteLine($"Intern ID: {empID}, Name: {name}, Duration: {duration} months, Stipend: {salary}");
        }
    }
    public class HR
    {
            static HR()
            {
                Console.WriteLine("HR System Initialized.");
            }
            private HR() { }

        public static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the HR Department.");
        }
    }
}
 


