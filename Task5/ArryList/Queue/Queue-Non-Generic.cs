using System.Collections;

namespace Queue_
{
    internal class Queue_
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();

            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            Console.WriteLine(que.Peek());

            que.Dequeue();

            Console.WriteLine(que.Peek());

            Queue_Generic.Generic();
        }
    }
}
