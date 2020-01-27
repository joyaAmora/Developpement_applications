using System;
using System.Collections.Generic;
using System.Text;

namespace ex_01
{
    class Car : Vehicule
    {
        public string Model { get; set; } // prop tab tab
        public int Year { get; set; }
        public string NIV { get; set; }
        public double EngineSize { get; set; }

        public Car() // ctor tab
        {

        }

        /* le $ sert a pouvoir séparer le contenu des propriétés plutôt que ça n'affiche Brand Model Color Year ...
         * => équivaut a un return
         */
        public string Display() => $"{Brand}\t{Model}\t{Color}\t{Year}\tEngine: {EngineSize} "; 
        /*  Pareil que de faire:
            public string Display()
            {
                return $"{Brand}\t{Model}\t{Color}\t{Year}\tEngine: {EngineSize} ";
            }
        */
    }

}
