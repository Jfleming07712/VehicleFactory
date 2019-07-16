using System;

namespace VehicleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Make Vehicles");

            SportsCar bmw = new SportsCar();
            Sedan lumina = new Sedan();
            PickUp f150 = new PickUp();
            Semi mack = new Semi();

            bmw.Go();
        }
    }
}
