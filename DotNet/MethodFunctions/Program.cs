namespace MethodFunctions
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Non return type method
            Printer();

            //Return type method
            Console.WriteLine(Calc());
        }
        public static void Printer()
        {
            Console.WriteLine("I am function");
            //Console.ReadKey();
        }
        public static int Calc()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            return c;
        }
        //public static float Calc()
        //{
        //    float a = 10;
        //    float b = 20;
        //    float c = a + b;
        //    return c;
        //}
    }
}