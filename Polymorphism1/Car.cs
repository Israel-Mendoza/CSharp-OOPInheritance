using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism1
{
    class Car
    {
        // Fields
        private int _hp;
        private string _color;

        // Properties
        public int HP 
        {
            get => this._hp;
            set
            {
                if (value < 0)
                    throw new Exception("Horse power must be a positive number...");
                else
                    this._hp = value;
            }
        }

        public string Color
        {
            get => this._color;
            set
            {
                if (String.IsNullOrEmpty(value))
                    this._color = "white";
                else
                    this._color = value;
            }
        }

        // Constructor
        public Car(int horsePower, string color="white")
        {
            this.HP = horsePower;
            this.Color = color?.ToLower();
        }

        // Methods
        public virtual void ShowDetails() => Console.WriteLine($"A {this.Color} car with {this.HP} HP.");

        public virtual void Repair() => Console.WriteLine("Car was repaired!");

    }
}
