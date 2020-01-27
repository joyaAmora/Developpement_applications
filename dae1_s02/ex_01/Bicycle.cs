using System;
using System.Collections.Generic;
using System.Text;

namespace ex_01
{
    class Bicycle: Vehicule
    {
        public string RingBell
        {
            get
            {
                return "Ding";
            }
        }
        public override string Indicate(bool turnLeft)
        {
            return turnLeft ? "Raising Left Arm" : "Raising Right Arm";
        }
    }
}
