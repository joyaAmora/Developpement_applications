using System;
using System.Collections.Generic;
using System.Text;

namespace ex_01
{
    class Bus: MotorVehicule
    {
        public int Passengers { get; set; }
        public int Capacity { get; set; }


        public int EmbarkPassenger (int nbPassenger)
        {
            if (nbPassenger + Passengers < Capacity)
            {
                Passengers += nbPassenger;
                return Capacity - Passengers;
            }
            else
            {
                return 0;
            }
        }

    }
}
