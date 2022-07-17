using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Exceptions
{
    class DivideException : Exception
    {
        public DivideException(string message) : base(message)
        {

        }
    }
}
