using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public class Bed : Part
    {
        public void Fill()
        {
            bool bedFull = true;
            Console.WriteLine("The bed is now full");
        }
    }
}
