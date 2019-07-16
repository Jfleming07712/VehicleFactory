using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public class FrontDoors : Part
    {
        public void FrontDoorsOpen()
        {
            Console.WriteLine("Front doors are now open");
        }
        public void FrontDoorsClose()
        {
            Console.WriteLine("Front doors are now closed");
        }
        
    }
}
