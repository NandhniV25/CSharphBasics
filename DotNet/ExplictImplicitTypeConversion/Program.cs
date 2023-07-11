namespace ExplicitImplicitTypeConversion
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Explicit Conversion
            float num1 = 1.5354f;
            int num = (int)num1;
            Console.WriteLine(num);

            //Implicit Conversion 
            int a = 1234;
            long b = a;
            Console.WriteLine(b);
            Console.WriteLine(b.GetType());

            //Type Conversion
            //int to string 
            int d = 10;
            string data = d.ToString();
            Console.WriteLine(data);
            Console.WriteLine(data.GetType());

            //string to int
            string da = "1900";
            int daa = int.Parse(da);//Int32.Parse(da)
            Console.WriteLine(daa);
            Console.WriteLine(daa.GetType());
        }
    }
}
