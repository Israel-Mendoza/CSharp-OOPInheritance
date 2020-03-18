using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism1
{
    class BMW : Car
    {
        // Fields
        private readonly string _brand = "BMW";
        private string _model;

        // Properties
        public string Brand { get => this._brand; }
        public string Model
        {
            get => this._model;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Model property must be a non-empty string...");
                else
                    this._model = value;
            }
        }

        // Constructor
        public BMW(string model, int horsePower, string color) : base(horsePower, color)
        {
            this.Model = model;
        }

        // Methods
        public sealed override void ShowDetails() => Console.WriteLine($"A {this.Color} {Model} {Brand} car with {this.HP} HP.");

        public override void Repair() => Console.WriteLine($"The {Model} was repaired!");
    }
}
