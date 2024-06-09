namespace Queue_
{
    internal class Queue_Generic
    {
        public static void Generic()
        {
            Queue<float> que = new Queue<float>();

            que.Enqueue(1.8f);
            que.Enqueue(2.6f);
            que.Enqueue(3.7f);
            que.Enqueue(4.3f);
            que.Enqueue(5.5f);

            Console.WriteLine(que.Peek());

            que.Dequeue();

            Console.WriteLine(que.Peek());
        }
    }
}
