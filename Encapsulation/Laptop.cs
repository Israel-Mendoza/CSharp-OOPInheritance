using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public abstract class Laptop
    {
        public abstract void TurnOn();

        public abstract void TurnOff();

        public abstract bool TouchScreen { get; }

        protected void PowerOnSelfTest() => Console.WriteLine("Checking laptop's hardware before booting up...");

    }
}
