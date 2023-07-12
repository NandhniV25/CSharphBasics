using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7Polymorphism
{
    public class SemiSchoolBus : SemiBus
    {
        public SemiSchoolBus(int wheel): base(wheel) 
        {
            
        }
        public override void BusDetails() // before override use sealed = not to override
        {
            Console.WriteLine($" This Semi-School-bus has {Wheel} wheels");
        }
    }
}
