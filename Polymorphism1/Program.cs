using System;
using System.Collections.Generic;

namespace Polymorphism1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAudi = new Audi("TT", 200, "Red");
            var myBMW = new BMW("i3", 150, "black");
            var yourAudi = new Audi("A4", 200, "Red");
            var yourBMW = new BMW("M5", 250, "black");

            var myCars = new List<Car>() { myAudi, myBMW, yourAudi, yourBMW };

            foreach (var car in myCars)
            {
                car.ShowDetails();
            }

            Console.WriteLine();

            Audi anotherAudi = (Audi) myAudi;
            anotherAudi.ShowDetails();
        }
    }
}
