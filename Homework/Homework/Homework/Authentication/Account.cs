using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Authentication
{
    public class Account : Exception
    {
        public Account(string message):base(message)
        {

        }
    }
}
