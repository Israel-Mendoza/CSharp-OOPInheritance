using System;

namespace Inheritance1
{
    class Horse : Mammal
    {

        public Horse(string horseName) : base(horseName) { }
        
        public void Gallop()
        {
            Console.WriteLine("I'm galloping throughn the meadows!!!");
        }
    }
}