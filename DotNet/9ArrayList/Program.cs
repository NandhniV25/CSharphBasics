using System.Collections;

namespace ArrayListt
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayList dataBook = new ArrayList();
            dataBook.Add(10);
            dataBook.Add(20);
            dataBook.Add("Hoi");
            dataBook.Add(12.34f);
            dataBook.Add(true);
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