using System;

namespace Program
{
    internal class Startup
    {
        static void Main(string[] args)
        {
            var tr1 = new Parking.Truck();
           





























            tr2.Go();
        }
    }
}



































namespace Parking
{
    internal class Truck
    {
        internal void Go()
        {
          
           Console.WriteLine("ok");
        }
    }
}

namespace Vehicles
{
    internal class Truck
    {
        internal void Go()
        {

            Console.WriteLine("running");
        }
    }
}
