using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface Laptop
    {

        void TurnOn();
        void TurnOn(bool accessBIOS);
        void TurnOff();
        bool TouchScreen { get; }

    }
}
