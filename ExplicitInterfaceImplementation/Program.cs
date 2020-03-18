using System;

namespace ExplicitInterfaceImplementation
{
    class Program : I1, I2
    {
        static void Main(string[] args)
        {
            var c1 = new Class1();
            
            // Casting to the appropriate Interface must be done prior to calling the implemented method
            ((I1) c1).InterfaceMethod();
            ((I2) c1).InterfaceMethod();

            // We can also create separate instances of the "Interfaces"
            I1 i1 = new Class1();
            I2 i2 = new Class1();

            i1.InterfaceMethod();
            i2.InterfaceMethod();

            // Default implementation in Class2 by implementing one implicitly

            var c2 = new Class2();

            c2.InterfaceMethod();
            ((I2) c2).InterfaceMethod();

        }

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
