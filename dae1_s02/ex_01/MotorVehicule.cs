using System;
using System.Collections.Generic;
using System.Text;

namespace ex_01
{
    class MotorVehicule: Vehicule
    {
        Vehicule vehicule;
        public double FuelRemaining { get; set; }
        public double TankSize { get; set; }

        public double mpg;
        public double Mpg
        {
            get
            {
                return mpg;
            }
            private set
            {
                mpg = _speed == 0 ? 0 : _speed < 20 ? 50 : _speed < 50 ? 40 : 35;
            }
        }
        

        public double Refuel()
        {
            double whatsMissing = TankSize - FuelRemaining;
            FuelRemaining = TankSize;
            return whatsMissing;            
        }
        public override string Indicate(bool turnLeft)
        {
            return turnLeft ? "Flashing Left indicator" : "Flashing Right indicator";
        }
    }
}
