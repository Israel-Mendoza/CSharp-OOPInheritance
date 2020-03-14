using System;

namespace Inheritance1
{
    class Gorilla : Mammal
    {

        public Gorilla(string gorillaName) : base(gorillaName) { }

        public void KickChest()
        {
            Console.WriteLine("I'm kicking my chest!!! AAAARRRGHHHHH!!!");
        }

        public override void Think()
        {
            Console.WriteLine("I instinctly \"think\" of bananas...");
        }

    }
}
