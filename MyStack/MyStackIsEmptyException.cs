using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    public class MyStackIsEmptyException : Exception
    {
        public MyStackIsEmptyException(string msg) : base(msg)
        {

        }
    }
}
