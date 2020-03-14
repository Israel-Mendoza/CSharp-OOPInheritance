using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    class Car : Vehicle
    {
        // Fields
        private int _numberOfDoors;
        private bool _usesBattery;
        
        // Constructor
        public Car(string modelName, int numberOfPassengers, int numberOfDoors, bool usesBattery) : base(modelName, numberOfPassengers)
        {
            NumberOfDoors = numberOfDoors;
            UsesBattery = usesBattery;
        }

        // Properties
        public int NumberOfDoors { get => _numberOfDoors; set => _numberOfDoors = value; }
        public bool UsesBattery { get => _usesBattery; set => _usesBattery = value; }

        // Methods
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine($"Driving the {Model}...");
        }
        public void SpeedUpd() => Console.WriteLine("Let's start racing!!!");
        public void Brake() => Console.WriteLine("It's time to stop... We have a red light!");
    }
}
