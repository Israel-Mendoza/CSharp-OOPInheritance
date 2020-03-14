using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Laptop myMacBook = new MacBookAir();
            Laptop myZenBook = new AsusZenBook();

            myMacBook.TurnOn();
            myMacBook.TurnOff();
            Console.WriteLine($"The MacBook Air has a touchscreen: {myMacBook.TouchScreen}\n"); 

            myZenBook.TurnOn();
            myZenBook.TurnOff();
            Console.WriteLine($"The Asus ZenBook has a touchscreen: {myZenBook.TouchScreen}");

        }
    }
}
