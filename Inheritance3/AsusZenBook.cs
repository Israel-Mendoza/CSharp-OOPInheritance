using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    class AsusZenBook : Laptop
    {

        public override void TurnOn()
        {
            Console.WriteLine("ASUS... IN SEARCH OF INCREDIBLE...\n\tLoading...");
        }

        public override bool TouchScreen => true;
    }
}
