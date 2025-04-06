using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_3a_
{
    public class MyCustomException : Exception
    {
        public int ErrorCode { get; private set; }

        public MyCustomException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }
    }
}
