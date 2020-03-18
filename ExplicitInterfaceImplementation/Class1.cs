using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitInterfaceImplementation
{
    class Class1 : I1, I2
    {
        // Implementing explicitly without an access modifier
        void I1.InterfaceMethod()
        {
            Console.WriteLine("Hello from I1!!!");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("Hello from I2!!!");
        }
    }
}
