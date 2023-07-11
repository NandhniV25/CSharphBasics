using System.Globalization;

namespace Operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculation(10, 2);

            //Relational Operations return true or false
            int a = 10;
            int b = 29;
            bool result = a != b;  //==, <, >, <=, >=
            Console.WriteLine(result);

            //Logical Operations 
            bool result1 = a < b && a == b;
            Console.WriteLine(result1);
            bool result2 = a < b || a != b;
            Console.WriteLine(result2);

            //Unary Operators 
            int num = 5;
            Console.WriteLine();
            Console.WriteLine(+num);
            Console.WriteLine(-num);
            Console.WriteLine(++num);
            Console.WriteLine(num);
            Console.WriteLine(num++);
            Console.WriteLine(num);
            Console.WriteLine(--num);
            Console.WriteLine(num);
            Console.WriteLine(num--);
            Console.WriteLine(num);

            bool res = false;
            Console.WriteLine(!res);

            //Ternary Operator
            int aa = 111;
            int bb = 222;
            string condition = a < b ? " a is less than b " : " a is greater than b ";
            Console.WriteLine(condition);
        }
        public static void Calculation(int x, int y)
        {
            //Arithmetic Operations
            var result = x + y;
            Console.WriteLine($"Addition = {result}");
            result = x - y;
            Console.WriteLine($"Subtraction = {result}");
            result = x * y;
            Console.WriteLine($"Multiplication = {result}");
            result = x / y;
            Console.WriteLine($"Division = {result}");
            result = x % y;
            Console.WriteLine($"Modulo = {result}");
        }
    }
}