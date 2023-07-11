using System.Collections;

namespace queue
{
    class Program
    {
        public static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            q.Enqueue(60);
            q.Enqueue(50);

            Console.WriteLine(q.ToString());
            Console.WriteLine(q.Count());
            Console.WriteLine(q.Peek());
            
            while (q.Count > 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }
    }
}