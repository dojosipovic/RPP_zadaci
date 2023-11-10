using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PametnaKuca2
{
    internal class HumiditySensor : Sensor
    {
        public override string Unit => "%";

        public HumiditySensor(int id, string unit) : base(id, unit)
        {
        }

        public override double GetValue()
        {
            return new Random().Next(30, 70);
        }
    }
}
