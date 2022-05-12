using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory = new ConcreteVehicleFactory();
            
            IFactory scooter = vehicleFactory.GetVehicle("SCOOTER");
            IFactory bike = vehicleFactory.GetVehicle("SCOOTER");

            bike.Drive(100);
            scooter.Drive(10);
            Console.ReadKey();


        }
    }
}
