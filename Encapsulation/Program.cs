using System;
using System.Collections.Generic;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {

            Laptop myZenBook = new AsusZenBook();
            Laptop myMacBook = new MacBookAir();

            myZenBook.TurnOn();
            myMacBook.TurnOn();

        }
    }
}
