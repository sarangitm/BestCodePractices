using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BestCodePractices.CustomExceptions
{
    public class MyException : Exception
    {
        public int StatusCode { get; set; }

        public MyException()
        {
            // Do your stuff
        }

        public MyException(int statusCode)
        {
            this.StatusCode = statusCode;
        }

        public MyException(int statusCode, string errorMessage)
            : base(errorMessage)
        {
            this.StatusCode = statusCode;
        }

        public MyException(int statusCode, Exception exception)
            : base(exception.Message, exception.InnerException)
        {
            this.StatusCode = statusCode;
        }
    }
}