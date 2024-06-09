namespace Stack_
{
    internal class Stack_Generic
    {
        public static void Generic_Stack()
        {
            Stack<char> chars = new Stack<char>();

            chars.Push('W');
            chars.Push('1');
            chars.Push('2');
            chars.Push('3');
            chars.Push('E');
            chars.Push('5');
            chars.Push('0');
            chars.Push('0');

            foreach (char c in chars)
            {
                Console.Write(c);
            }

            Console.WriteLine();     

            chars.Pop();
            chars.Pop();
            chars.Pop();
            chars.Pop();

            foreach (char c in chars)
            {
                Console.Write(c);
            }
        }
    }
}
