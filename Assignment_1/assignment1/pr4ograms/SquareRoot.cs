using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.pr4ograms

{
    class SquareRoot
    {
        public static void Run()
        {
            Console.Write("Enter a number to calculate square root: ");
            try
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 0) throw new ArgumentException("Number cannot be negative");
                Console.WriteLine("Square Root: " + Math.Sqrt(num));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}

