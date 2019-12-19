using System;
using System.Collections;
using System.Collections.Generic;

namespace StackMin
{
    class StackMin
    {
        Stack stack;
        int minElement;

        public StackMin()
        {
            stack = new Stack();
        }
        public void Push(int value)
        {
            if(stack.Count == 0)
            {
                minElement = value;
                stack.Push(value);
                return;
            }
            if (value > minElement)
            {
                stack.Push(value);
                Console.WriteLine(value);
            }
            else
            {
                value = 2 * value - minElement;
                stack.Push(value);
                minElement = value;
                Console.WriteLine(minElement);
            }
        }

        public void Pop()
        {
            int value = (int)stack.Peek();
            if (value > minElement)
                Console.WriteLine((int)stack.Pop());
            else
            {
                minElement = 2 *minElement - value ;
                Console.WriteLine((int)stack.Pop());
            }
        }

        public int Min()
        {
            if (minElement != 0)
                return minElement;
            else
                return -1;
        }
    }
    class Program
    {
        static void Main()
        {

            StackMin s = new StackMin();
            s.Push(3);
            s.Push(5);
            s.Min();
            s.Push(2);
            s.Push(1);
            s.Min();
            s.Pop();
            s.Min();
            s.Pop();
        }
    }
}
