namespace Looping
{
    class Program
    {
        public static void Main(string[] args) 
        {
            //for loop
            Console.WriteLine("for loop");
            int n1 = 10;
            for (int i = 0; i < n1; i++) 
            {
                Console.WriteLine(i);
            }

            //while loop
            Console.WriteLine("while loop");
            int n2 = 0;
            while (n2<10)
            {
                Console.WriteLine(n2);
                n2++;
            }

            //do-while loop
            Console.WriteLine("do-while loop");
            int n3 = 0;
            do
            {
                Console.WriteLine(n3);
                n3++;
            } while (n3 < 10);
        }
    }
}