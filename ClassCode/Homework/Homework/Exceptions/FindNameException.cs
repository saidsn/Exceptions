using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Exceptions
{
    public class FindNameException : Exception
    {
        public FindNameException(string message) :base(message)
        {

        }
    }
}
