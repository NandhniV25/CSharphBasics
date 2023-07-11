using System.Collections;

namespace stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();
            s.Push(10);
            s.Push(20);
            s.Push(30);
            s.Push(40);
            s.Push(60);
            s.Push(50);

            Console.WriteLine(s.ToString());
            Console.WriteLine(s.Count());
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());


            while(s.Count > 0)
            {
                Console.WriteLine(s.Pop());
            }
        }
    }
}