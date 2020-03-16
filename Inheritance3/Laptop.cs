using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    public abstract class Laptop
    {

        public virtual void TurnOn()        // Method can be used by derived classes or it can be overriden
        {
            Console.WriteLine("Turning device on...");
        }

        public void TurnOff()               // Method is to be used by derived classes. Cannot be overriden
        {
            Console.WriteLine("Turning device off...");
        }

        public abstract bool TouchScreen { get; }   // Property must be defined in derived classes before using it.
    }
}
