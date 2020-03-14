using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class AsusZenBook : Laptop
    {
        public override void TurnOn()
        {
            Console.WriteLine("IN SEARCH OF INCREDIBLE...  Please wait...");
            base.PowerOnSelfTest();
            this.BIOSROM();
            this.BootLoader();
            this.OSConfig();
            this.Security();
        }

        public override void TurnOff() => Console.WriteLine("Turning off ZenBook...");

        public override bool TouchScreen { get => true; }

        private void BIOSROM() => Console.WriteLine("BIOS ROM process...");

        private void BootLoader() => Console.WriteLine("Boot Loader phase is happening...");

        private void OSConfig() => Console.WriteLine("OS configuration phase is happening...");

        private void Security() => Console.WriteLine("Security logon phase is happening...");
    }
}
