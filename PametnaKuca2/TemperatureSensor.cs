using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PametnaKuca2
{
    internal class TemperatureSensor : Sensor
    {
        public override string Unit => "Celsius";

        public TemperatureSensor(int id, string unit) : base(id, unit)
        {
        }

        public override double GetValue()
        {
            var random = new Random();
            return 18 + random.NextDouble() + random.Next(3);
        }
    }
}
