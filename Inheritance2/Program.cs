using System;
using System.Collections.Generic;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehicle aVehicule = new Vehicle("ABC 123", 1);
            Car myCar = new Car("Seat Ibiza", 4, 4, false);
            Plane aPlane = new Plane("Airbus 320", 186, "Passenger");

            List<Vehicle> myVehicleList = new List<Vehicle> {aVehicule, myCar, aPlane};

            foreach (Vehicle v in myVehicleList)
                v.Drive();
        }
    }
}
