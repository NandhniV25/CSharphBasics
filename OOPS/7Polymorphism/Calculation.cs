using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Polymorphism
{
    public class Calculation
    {
        public void Add(int x, int y)
        {
            Console.WriteLine($" Addition of two numbers = {x + y} ");
        }
        public void Add(int x, int y, int z)
        {
            Console.WriteLine($" Addition of three numbers = {x + y + z} ");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($" Subraction of two numbers = {x - y} ");
        }
    }
}
