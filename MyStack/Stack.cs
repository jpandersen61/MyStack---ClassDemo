using System;

namespace MyStack
{
    public class Stack
    {
        int _size;            //Keeps track of the size of the stack, starting at zero 
        int [] _stack;        //Stack implemented as an array
        int _currentStackPos; //Holds the current stack pos

        public Stack(int size)
        {
            _size = size;
            _stack = new int[size];
            _currentStackPos=0;
        }

        public int Pop()
        {
            _currentStackPos--;
            return _stack[_currentStackPos];
        }

        public void Push(int element)
        {
            _stack[_currentStackPos] = element;
            _currentStackPos++;
        }
    }
}
