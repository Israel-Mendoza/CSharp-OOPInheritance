using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces3
{
    class Customer : ICustomer, I3
    {
        public void I2Method()
        {
            Console.WriteLine("I2 I2Method() method...");
        }

        public void Print()
        {
            Console.WriteLine("Interface Print() method...");
        }

        public void YetAnotherInterfaceMethod()
        {
            Console.WriteLine("Hello from impletemented method...");
        }
    }
}
