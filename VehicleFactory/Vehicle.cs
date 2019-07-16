using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public int Vin { get; set; }
        public Engine Engine { get; set; }
        public FrontDoors FrontDoors { get; set; }

    }
}

