using System;

namespace AbstractClasses2
{
    public class Program : Customer
    {
        static void Main(string[] args)
        {
            var p = new Program();

            // Using the method that was forced to be implemented:
            p.Print();

            // Using an implemented method in the abstract class, which was inherited by Program:
            p.Greet();
        }

        public override void Print()
        {
            Console.WriteLine("Hello from the recently implemented Print() method!");
        }
    }
}
