using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public class BackDoors : Part
    {
        public bool backDoorsOpen = false;
        public void Open()
        {
            Console.WriteLine("Back doors are now open");
            var backDoorsOpen = true;
        }

        public void Close()
        {
            bool backDoorsOpen = false;
            Console.WriteLine("Back doors are now closed");
        }
    }
}
