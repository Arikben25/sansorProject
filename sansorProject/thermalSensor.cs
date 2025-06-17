using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sansorProject
{
    internal class ThermalSensor : Sensors 
    {
        string name { get; set; }

        internal ThermalSensor() : base("termi") { this.name = "termi"; }
    }
}
