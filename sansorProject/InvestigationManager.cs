using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sansorProject
{
    internal class Manager
    {
        
        internal void manager()
        {
            rankLevel level = agrntLevel();
            List<string> sensors = enterSensor();
            Agent agent = new Agent(level,sensors);
        }
        internal List<string> enterSensor()
        {
            List<string> sensor = new List<string>();

            for (int i = 0; i < 2; i++) {
                Console.WriteLine("Select a sensor, for a thermal sensor press '1'," +
                    "\n\rfor a moving image sensor press '2'.");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    sensor.Add("termi");
                }
                else if (num == 2)
                {
                    sensor.Add("mooving");
                }   
            }
                return sensor; 
        }
        
        internal rankLevel agrntLevel()
        {
            rankLevel leveli = rankLevel.junior;

Console.WriteLine("Select agent level,\r\nfor junior press 1,\r\nfor mac press 2,\r\nfor map press 3,\r\nfor senior press 4,");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                     leveli = rankLevel.junior;
                    break;
                case 2:
                     leveli = rankLevel.mac;
                    break;
                case 3:
                    leveli = rankLevel.map;
                    break;
                case 4:
                    leveli = rankLevel.senior;
                    break;
                default:
                    Console.WriteLine("Enter only a number between 1 and 4.");
                    break;
            }
            
            return leveli;
        }

    }
}
