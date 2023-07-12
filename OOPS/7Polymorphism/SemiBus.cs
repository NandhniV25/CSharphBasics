using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Polymorphism
{
    public class SemiBus : Bus     
    {
        public SemiBus(int wheel) : base(wheel)
        {
            
        }
        public new void BusCapacity() // new keyword used to hide inherited func
        {
            Console.WriteLine(" The semibus has 30 capacity");
        }
        public override void BusDetails()
        {
            Console.WriteLine($" This semi-bus has {Wheel} wheels");
        }
    }
}
