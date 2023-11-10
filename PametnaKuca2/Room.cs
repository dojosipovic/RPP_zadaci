using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PametnaKuca2
{
    internal class Room
    {
        public string Name { get; }
        public List<Sensor> Sensors { get; set; } = new List<Sensor>();

        public Room(string name)
        {
            Name = name;
        }

        public virtual string GenerateTextualReport()
        {
            string report = "";

            Sensors.ForEach(sensor => report += $"Current value for sensor {sensor.ID} is {sensor.GetValue()} {sensor.Unit}\n");

            return report;
        }
    }
}
