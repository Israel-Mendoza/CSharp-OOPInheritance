using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance2
{
    class Vehicle
    {
        // Fields
        private string _modelName;
        private int _numberOfPassengers;

        // Constructor
        public Vehicle(string modelName, int numberOfPassengers)
        {
            Model = modelName;
            NumberOfPassengers = numberOfPassengers;
        }

        // Properties
        public string Model { get => _modelName; set => _modelName = value; }
        public int NumberOfPassengers { get => _numberOfPassengers; set => _numberOfPassengers = value; }

        // Methods
        public void StartEngine() => Console.WriteLine($"Starting the {Model}'s engine");
        public void StopEngine() => Console.WriteLine($"Stopping the {Model}'s engine");
        public virtual void Drive() => Console.WriteLine($"The {Model} is on the move...");
    }
}
