using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public class Vehicle
    {
        public string Name { get; set; }
        public int Vin { get; set; }
        public Engine Engine { get; set; }
        public FrontDoors FrontDoors { get; set; }

        // second approach, a good approach when you know the front doors will always be front doors and you just need them to be there.  A good approach when you have a List of things because the list always exists, but not necessarily the things in the list.
        //public FrontDoors FrontDoors { get; set; } = new FrontDoors();

    }
}

