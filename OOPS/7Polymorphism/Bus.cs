using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Polymorphism
{
    public class Bus
    {
        public int Wheel { get; set; }

        public Bus(int wheel)
        {
            Wheel = wheel;
        }
        public void BusCapacity()
        {
            Console.WriteLine(" The bus has 40 capacity");
        }

        public virtual void BusDetails()
        {
            Console.WriteLine($" This bus has {Wheel} wheels");
        }
    }
}
