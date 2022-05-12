using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    //Product Interface
    public interface IFactory
    {
        void Drive(int miles);

    }
    //Concrete Product
    public class Scooter : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the scooter at speed : {0} km",miles);
        }
    }
    //Concrete Product
    public class Bike : IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Drive the bike at speed : {0} km", miles);
        }
    }



}
