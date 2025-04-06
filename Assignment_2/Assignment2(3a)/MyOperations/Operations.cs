using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOperations
{
    public class MyOperations
    {
        public static int SafeDivide(int numerator, int denominator)
        {
            try
            {
                return numerator / denominator;
            }
            catch (DivideByZeroException)
            {
                throw new MyCustomException(1001, "Error: Attempted to divide by zero.");
            }
        }

        public static int GetArrayElement(int[] arr, int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException)
            {
                throw new MyCustomException(1002, "Error: Index is out of range.");
            }
        }
    }
}
