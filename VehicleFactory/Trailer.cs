using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public class Trailer : Part
    {
        public void Fill()
        {
            Console.WriteLine("Trailer is now full");
        }
        public void Empty()
        {
            Console.WriteLine("Trailer is now empty");
        }
    }
}
