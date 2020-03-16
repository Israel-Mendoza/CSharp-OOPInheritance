using System;

namespace Inheritance1
{
    class Mammal
    {

        private string _livingBeingName;

        public Mammal(string name)
        {
            this._livingBeingName = name;
        }
        
        public virtual void Think()
        {
            Console.WriteLine("Basic instinc thoughts...");
        }
        
        public void Breath()
        {
            Console.WriteLine("I am able to breath air!!!");
        }

        public void TakeCareOfOffpring()
        {
            Console.WriteLine("I am taking care of my offspring until they grow up...");
        }

        public void GetName()
        {
            Console.WriteLine($"Hello, my name is {_livingBeingName}");
        }

        protected void Test()
        {
            Console.WriteLine("Hello from the \"protected void Test\" method declared under the Mammal class...");
        }
    }
}
