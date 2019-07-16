using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public class Bed : Part
    {
        public void Fill()
        {
            Console.WriteLine("The bed is now full");
        }
        public void Empty()
        {
            Console.WriteLine("The bed is now empty");
        }
    }
}
