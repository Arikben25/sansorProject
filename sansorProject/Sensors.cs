using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace sansorProject
{
  
    internal abstract class Sensors
    {

        string name { get; set; }
        bool start { get; set; }

        internal Sensors(string name)
        {
            this.name = name;
        }

        internal virtual void activate()
        {
            this.start = true;
            Console.WriteLine($"the sensor {name} is 'on'");
        }

    }
}
