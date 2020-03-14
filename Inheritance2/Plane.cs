using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    class Plane : Vehicle
    {
        // Fields
        private string _usage;

        // Constructor
        public Plane(string modelName, int numberOfPassengers, string usage) : base(modelName, numberOfPassengers)
        {
            Usage = usage;
        }

        // Properties
        public string Usage { get => _usage; set => _usage = value; }

        // Methods
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine($"The {Model} is flighing through the air!");
        }
        public void TakeOff() => Console.WriteLine($"The {Model} is taking off!!!");
        public void Land() => Console.WriteLine($"The {Model} is about to land... Fasten your seatbelts!");
    }
}
