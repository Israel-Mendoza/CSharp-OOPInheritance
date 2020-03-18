using System;

namespace Interfaces3
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Customer();
            c.Print();
            c.I2Method();
            c.YetAnotherInterfaceMethod();

            ICustomer ic = new Customer();
            // The ic object has access to the method required by the ICustomer interface
            ic.Print();
        }
    }
}
