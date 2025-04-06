using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.pr4ograms
{

    class ShuffleString
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Shuffled String: " + ShuffleFirstLast(input));
        }

        static string ShuffleFirstLast(string str)
        {
            if (str.Length <= 1) return str;
            return str[str.Length - 1] + str.Substring(1, str.Length - 2) + str[0];


        }
    }
}
