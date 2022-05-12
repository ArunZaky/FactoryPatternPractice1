using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    //Creator "A Abstract Class"
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
        
    }
    //Concrete Creator
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(string Vehicle)
        {
            switch (Vehicle.ToLower())
            {
                case "scooter":
                    return new Scooter();
                    
                case "bike":
                    return new Bike();
                    
                default:
                    throw new ApplicationException(string.Format("Vehicle {0} cannot be created",Vehicle));

            }



        }
    }
}
