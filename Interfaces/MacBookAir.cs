using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class MacBookAir : Laptop
    {

        public void TurnOn() => Console.WriteLine("Apple... Turning on...");

        public void TurnOn(bool accessBIOS)
        {
            if (accessBIOS)
                Console.WriteLine("Launching Apple BIOS GUI...");
            else
                TurnOn();
        }

        public void TurnOff() => Console.WriteLine("Turning off MacBook Air...");
        
        public bool TouchScreen { get => false;  }

    }
}
