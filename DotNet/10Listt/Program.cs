using System.Collections;

namespace Listt
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> dataBook = new List<int>();
            dataBook.Add(10);
            dataBook.Add(20);
            dataBook.Add(30);
            dataBook.Add(40);
            dataBook.Add(60);
            dataBook.Add(50);

            //foreach (var item in dataBook)
            //{
            //    Console.WriteLine(item);
            //}  

            Console.WriteLine("after removal");
            dataBook.Remove(10);
            dataBook.RemoveAt(3);
            foreach (var item in dataBook)
            {
                Console.WriteLine(item);
            }
        }
    }
}