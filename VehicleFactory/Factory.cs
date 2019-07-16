using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleFactory
{
    
    public class TeslaFactory
    {
        public void BuildTesla(SportsCar sportscar)
        {
            sportscar.FrontDoors = new FrontDoors();
            sportscar.Engine = new Engine();
            sportscar.Turbo = new Turbo();
        }
    }

    public class LuminaFactory
    {
        public void BuildLumina(Sedan sedan)
        {
            sedan.FrontDoors = new FrontDoors();
            sedan.Engine = new Engine();
            sedan.BackDoors = new BackDoors();
            sedan.Childseat = new ChildSeat();
        }
    }
    public class F150Factory
    {
        public void BuildF150(PickUp pickUp)
        {
            pickUp.FrontDoors = new FrontDoors();
            pickUp.Engine = new Engine();
            pickUp.Bed = new Bed();
        }
    }
    public class MackFactory
    {
        public void BuildMack(Semi semi)
        {
            semi.FrontDoors = new FrontDoors();
            semi.Engine = new Engine();
            semi.Trailer = new Trailer();
        }
    }

}
