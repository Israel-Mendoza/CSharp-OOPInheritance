using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses2
{
    public abstract class Customer
    {
        public abstract void Print();

        public void Greet()
        {
            Console.WriteLine("Hello from the inherited implemented method!!!");
        }
    }
}
