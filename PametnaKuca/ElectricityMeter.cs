using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PametnaKuca
{
    internal class ElectricityMeter : Meter
    {
        public ElectricityMeter(string name, string unit, string rawData) : base(name, unit, rawData)
        {
        }

        public override double[] GetDailyData()
        {
            string[] data = RawData.Split(';');
            double[] doubles = new double[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                doubles[i] = double.Parse(data[i]);
            }

            return doubles;
        }
    }
}
