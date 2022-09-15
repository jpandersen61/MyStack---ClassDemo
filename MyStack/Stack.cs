using System;

namespace MyStack
{
    public class Stack<T>
    {
        int _size;    //Keeps track of the size of the stack, starting at zero 
        T [] _stack; //Stack implemented as an array
        int _currentStackPos;

        public Stack(int size)
        {
            _size = size;
            _stack = new T[size];

            _currentStackPos=0;
        }

        public T Pop()
        {
            if (_currentStackPos < 1)
            {
                throw new MyStackIsEmptyException("Stack is empty");
            }
            T result = _stack[_currentStackPos-1];
            _currentStackPos--;
            return result;
        }

        public void Push(T element)
        {
            if (_currentStackPos >= _size)
            {
                throw new MyStackIsFullException("Stack full");
            }
            _stack[_currentStackPos] = element;
            _currentStackPos++;     
        }
    }
}
