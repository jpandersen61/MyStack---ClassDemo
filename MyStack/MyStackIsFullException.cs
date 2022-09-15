using System;
using System.Collections.Generic;
using System.Text;

namespace MyStack
{
    public class MyStackIsFullException : Exception
    {
        public MyStackIsFullException(string msg) : base(msg)
        {

        }
    }
}
