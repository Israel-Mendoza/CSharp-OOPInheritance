using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism1
{
    class M3 : BMW
    {
        // Constructor
        public M3(string color) : base(model: "M3", horsePower: 180, color)
        {
        }
    }
}
