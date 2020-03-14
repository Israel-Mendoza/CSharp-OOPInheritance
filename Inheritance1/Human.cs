using System;

namespace Inheritance1
{
    class Human : Mammal
    {

        private string _nationality;
        
        public Human(string humanName, string nationality) : base(humanName) 
        {
            this._nationality = nationality;
        }

        public override void Think()
        {
            Console.WriteLine("I am able to think!!!");
        }

    }
}
