using System;
using System.Collections.Generic;
using System.Text;

namespace ex_01
{
    class Vehicule
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        protected double _speed { get; set; }

        public void Accelerate(double speed)
        {
            _speed+= speed;
        }

        public virtual string Indicate (bool turnLeft)
        {
            return turnLeft ? "Turn Left" : "Turn Right";
        }
    }
}
