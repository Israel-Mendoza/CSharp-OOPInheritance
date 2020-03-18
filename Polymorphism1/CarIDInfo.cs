using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism1
{
    class CarIDInfo
    {
        public int IDNumber { get; set; }
        public string Owner { get; set; }

        // Constructor
        public CarIDInfo(int carID=0, string owner="No Owner")
        {
            this.IDNumber = carID;
            this.Owner = owner;
        }

    }
}
