using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class AsusZenBook : Laptop
    {
        
        public void TurnOn() => Console.WriteLine("IN SEARCH OF INCREDIBLE...  Please wait...");

        public void TurnOn(bool accessBIOS)
        {
            if (accessBIOS)
                Console.WriteLine("Launching Asus UEFI GUI...");
            else
                TurnOn();
        }

        public void TurnOff() => Console.WriteLine("Turning off ZenBook...");

        public bool TouchScreen { get => true; }

    }
}
