using System;

namespace MyStack
{
    public class Stack
    {
        int _size;    //Keeps track of the size of the stack, starting at zero 
        int[] _stack; //Stack implemented as an array
        int _currentStackPos;

        public Stack(int size)
        {
            _size = size;
            _stack = new int[size];

            _currentStackPos=0;
        }

        public int Pop()
        {
            if (_currentStackPos < 1)
            {
                throw new MyStackIsEmptyException("Stack is empty");
            }
            int result = _stack[_currentStackPos-1];
            _currentStackPos--;
            return result;
        }

        public void Push(int element)
        {
            _stack[_currentStackPos] = element;
            _currentStackPos++;     
        }
    }
}
