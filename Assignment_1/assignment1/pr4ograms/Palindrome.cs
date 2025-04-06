using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1.pr4ograms
{

    class Palindrome
    {
        public static void Run()
        {
            Console.Write("Enter a number to check palindrome: ");
            string numStr = Console.ReadLine();
            Console.WriteLine($"Is Palindrome (Non-Recursion): {IsPalindrome(numStr)}");
            Console.WriteLine($"Is Palindrome (Recursion): {IsPalindromeRecursive(numStr, 0, numStr.Length - 1)}");
        }

        static bool IsPalindrome(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return str == new string(arr);
        }

        static bool IsPalindromeRecursive(string str, int left, int right)
        {
            if (left >= right) return true;
            if (str[left] != str[right]) return false;
            return IsPalindromeRecursive(str, left + 1, right - 1);
        }
    }
}