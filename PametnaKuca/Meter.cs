using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PametnaKuca
{
    internal abstract class Meter
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        protected string RawData { get; set; }

        public Meter(string name, string unit, string rawData)
        {
            Name = name;
            Unit = unit;
            RawData = rawData;
        }

        public abstract double[] GetDailyData();

        public double CalculateDailySum()
        {
            return GetDailyData().Sum();
        }
    }
}
