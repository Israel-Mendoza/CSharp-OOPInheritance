using System;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {

            var myNotification = new Notification("Victor Bouche sale", "Hola, perrasno!", "Today");

            myNotification.ShowNotification();

        }
    }
}
