using System;

namespace VehicleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets Make Vehicles");


            SportsCar tesla = new SportsCar();
            Sedan lumina = new Sedan();
            PickUp f150 = new PickUp();
            Semi mack = new Semi();
            Gas gas = new Gas();
            Electricity electricity = new Electricity();
            Diesel diesel = new Diesel();


            tesla.FrontDoors.FrontDoorsOpen();
            tesla.FrontDoors.FrontDoorsClose();
            tesla.Engine.Go(electricity);
            tesla.Turbo.GoFast();

            lumina.FrontDoors.FrontDoorsOpen();
            lumina.FrontDoors.FrontDoorsClose();
            lumina.BackDoors.BackDoorsOpen();
            lumina.Childseat.ProtectChild();
            lumina.BackDoors.BackDoorsClose();
            lumina.Engine.Go(gas);
            lumina.BackDoors.BackDoorsOpen();
            lumina.Childseat.ProtectChild();
            lumina.BackDoors.BackDoorsClose();

            f150.Bed.Fill();
            f150.FrontDoors.FrontDoorsOpen();
            f150.FrontDoors.FrontDoorsClose();
            f150.Engine.Go(gas);
            f150.Bed.Empty();

            mack.Trailer.Fill();
            mack.FrontDoors.FrontDoorsOpen();
            mack.FrontDoors.FrontDoorsClose();
            mack.Engine.Go(diesel);






        }
    }
}
