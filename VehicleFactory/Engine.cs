using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    public class Engine : Part
    {
        public void Go(Gas gas)
        {
            Console.WriteLine("vroom");
        }
        public void Go(Diesel diesel)
        {
            Console.WriteLine("BLUB BLUB BLUB");
        }
        public void Go(Electricity electricity)
        {
            Console.WriteLine("Is this thing on?");
        }
    }
}
