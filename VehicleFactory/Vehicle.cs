using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public int Vin { get; set; }

        public void Go()
        {
            Console.WriteLine("vroom");
        }
        public void Stop()
        {
            Console.WriteLine("screetch");
        }

    }
}
