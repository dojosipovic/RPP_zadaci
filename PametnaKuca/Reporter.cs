using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PametnaKuca
{
    internal class Reporter
    {
        public string CreateDailySumReport(Meter meter)
        {
            return $"Daily total value is {meter.CalculateDailySum()} {meter.Unit}";
        }
    }
}
