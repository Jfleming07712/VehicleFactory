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

            var teslaFactory = new TeslaFactory();
            var luminaFactory = new LuminaFactory();
            var f150Factory = new F150Factory();
            var mackFactory = new MackFactory();

            // if you're building a factory this makes sense, you let the door factory make the doors.
            teslaFactory.BuildTesla(tesla);
            luminaFactory.BuildLumina(lumina);
            f150Factory.BuildF150(f150);
            mackFactory.BuildMack(mack);


            // first method, but is it this main method's responsibility to make this?
            //tesla.FrontDoors = new FrontDoors();

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
        

        //public class doorfactory
        //{
        //    public void attachdoors(vehicle vehicle) {
        //        if(vehicle.cost > 1000000) {
        //            // attach doors that go like this: \_/
        //        } else {
        //            vehicle.frontdoors = new frontdoors();
        //        }
        //    }
        //}
    }
}
