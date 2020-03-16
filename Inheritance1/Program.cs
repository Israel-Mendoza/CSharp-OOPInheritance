using System;

namespace Inheritance1
{
    class Program
    {
        static Horse spirit = new Horse("Spirit");
        static Human john = new Human("John", "Australian");
        static Gorilla kong = new Gorilla("King Kong");
        static Mammal aThing = new Mammal("A thing");

        static void Main(string[] args)
        {

            // IntroduceMammals();

            Mammal[] myAnimals = new Mammal[] { spirit, john, kong, aThing };

            foreach (Mammal animal in myAnimals)
            {
                animal.Think();
            }

            Console.ReadLine();
        }

        public static void IntroduceMammals()
        {
            Console.WriteLine("Using an instance of the class \"Mammal\": ");
            aThing.GetName();
            aThing.Breath();
            aThing.TakeCareOfOffpring();
            aThing.Think();
            Console.WriteLine();

            Console.WriteLine("Using an instance of the class \"Horse\": ");
            spirit.GetName();
            spirit.Breath();
            spirit.TakeCareOfOffpring();
            spirit.Gallop();
            spirit.Think();
            Console.WriteLine();

            Console.WriteLine("Using an instance of the class \"Human\": ");
            john.GetName();
            john.Breath();
            john.TakeCareOfOffpring();
            john.Think();
            Console.WriteLine();

            Console.WriteLine("Using an instance of the class \"Gorilla\": ");
            kong.GetName();
            kong.Breath();
            kong.TakeCareOfOffpring();
            kong.KickChest();
            kong.Think();
            Console.WriteLine();
        }
    }
}
