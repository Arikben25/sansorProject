using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sansorProject
{
    internal class MovementSensor:Sensors
    {
        string name { get; set; }

        internal MovementSensor() : base("mooving") { this.name = "mooving"; }
    }
}
