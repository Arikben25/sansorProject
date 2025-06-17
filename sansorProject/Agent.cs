using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sansorProject
{
    internal enum rankLevel
    {
        junior = 2,
        mac = 3,
        map = 4,
        senior = 5
    }

    internal class Agent
    {
        string name { get; set; }
        rankLevel level { get; set; }
        string[] weaknesses { get; set; }
        string[] allSensors { get; set; }
        List<string> attached { get; set; } = new List<string>();
        //Sensors[] allSensors { get; set; }




        internal Agent()
        {
            this.name = name;
            this.level = level;
            this.allSensors = new string[] { "mooving", "termi" };

            this.weaknesses = setWeaknessesSensor();
            //this.allSensors = new Sensors [] { new MovementSensor(),new ThermalSensor() };

        }


        Random rand = new Random();

        internal string[] setWeaknessesSensor()
        {

            string[] sensors = new string[(int)rankLevel.junior];
            for (int i = 0; i < (int)rankLevel.junior; i++)
            {
                int index = rand.Next((int)rankLevel.junior);
                sensors[i] = allSensors[index];
            }
            return sensors;
        }
        internal void addSensor(string sensorName)
        {
            attached.Add(sensorName);
        }

    }
}