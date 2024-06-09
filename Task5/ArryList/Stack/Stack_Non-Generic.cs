using System.Collections;

namespace Stack_
{
    internal class Stack_Non_Generic 
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(5.8);
            stack.Push(5.9);
            stack.Push(1.97);
            stack.Push(9.24);

            foreach (double i in stack) {
                Console.WriteLine(i);
            }

            Console.WriteLine(stack.Pop());

            foreach (double i in stack)
            {
                Console.WriteLine(i);
            }

            Stack_Generic.Generic_Stack();
        }
    }
}
