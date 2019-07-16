using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public class BackDoors : Part
    {
        public void BackDoorsOpen()
        {
            Console.WriteLine("Back doors are now open");
        }

        public void BackDoorsClose()
        {
            Console.WriteLine("Back doors are now closed");
        }
    }
}
