using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop myMacBook = new MacBookAir();
            Laptop myZenBook = new AsusZenBook();

            myMacBook.TurnOn(true);
            myMacBook.TurnOff();
            Console.WriteLine($"The MacBook Air has a touchscreen: {myMacBook.TouchScreen}\n");

            myZenBook.TurnOn(true);
            myZenBook.TurnOff();
            Console.WriteLine($"The Asus ZenBook has a touchscreen: {myZenBook.TouchScreen}\n");

            List<Laptop> myLaptops = new List<Laptop> { myMacBook, myZenBook };

            foreach (var laptop in myLaptops)
            {
                laptop.TurnOn();
                laptop.TurnOn(true);
            }
        }
    }
}
