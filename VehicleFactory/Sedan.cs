using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public class Sedan : Car
    {
        public ChildSeat Childseat { get; set; }
        public BackDoors BackDoors { get; set; }
    }
}
