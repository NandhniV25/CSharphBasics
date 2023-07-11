namespace Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            //int[] num = new int[] { 1, 2, 3, 4, 5 };
            //int[] num = new int[5];
            int[] num = { 1, 2, 3, 4, 5 };

            //for loop
            Console.WriteLine("for loop");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }

            //foreach loop
            Console.WriteLine("foreach loop");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
