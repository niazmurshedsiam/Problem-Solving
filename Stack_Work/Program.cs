using System;

namespace StackExample
{
    class Stack
    {
        const int MAX = 10;
        int[] items = new int[MAX];
        int top = -1;
        int count = 0;

        public void Push(int newItem)
        {
            if (IsFull())
            {
                Console.WriteLine("STACK FULL");
            }
            else
            {
                top++;
                items[top] = newItem;
            }
            count++;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("\n STACK EMPTY \n");
            }
            else
            {
                Console.WriteLine("Item popped= {0}", items[top]);
                top--;
            }
            count--;
            Console.WriteLine();
        }

        public void PrintStack()
        {
            Console.Write("Stack: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write("{0} ", items[i]);
            }
            Console.WriteLine();
        }

        public bool IsFull()
        {
            return top == MAX - 1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();

            s.Push(11);
            s.Push(22);
            s.Push(33);
            s.Push(44);

            s.PrintStack();

            s.Pop();

            Console.WriteLine("\nAfter popping out\n");
            s.PrintStack();
        }
    }
}

