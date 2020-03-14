using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class MacBookAir : Laptop
    {
        public override void TurnOn()
        {
            Console.WriteLine("Apple... Turning on...");
            base.PowerOnSelfTest();
            this.BootROMLoaded();
            this.BootROMRunning();
            this.FindBooterFile();
            this.LoadKernel();
        }

        public override void TurnOff() => Console.WriteLine("Turning off MacBook Air...");

        public override bool TouchScreen { get => false; }

        private void BootROMLoaded() => Console.WriteLine("Boot ROM loade...");

        private void BootROMRunning() => Console.WriteLine("Boot ROM running...");

        private void FindBooterFile() => Console.WriteLine("Finding booter file...");

        private void LoadKernel() => Console.WriteLine("Booter loads the kernel...");
    }
}
