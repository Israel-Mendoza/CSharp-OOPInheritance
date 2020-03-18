using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaceImplementation
{
        class Class2 : I1, I2
    {
        // Implementing explicitly without an access modifier
        public void InterfaceMethod()
        {
            Console.WriteLine("Hello from I1!!!");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("Hello from I2!!!");
        }
    }
}
