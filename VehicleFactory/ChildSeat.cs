using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public class ChildSeat : Part
    {
        public void ProtectChild()
        {
            Console.WriteLine("Child is now restrained");
        }
        public void FreeChild()
        {
            Console.WriteLine("Child is now free... Well Fuck");
        }
    }
}
