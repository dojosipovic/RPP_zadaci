using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PametnaKuca
{
    internal class SmartHomeSystem
    {
        public List<Meter> Meters { get; set; }

        public string GetReports()
        {
            var report = "";
            var reporter = new Reporter();
            foreach (Meter meter in Meters)
            {
                report += reporter.CreateDailySumReport(meter) + "\n";
            }

            return report;
        }
    }
}
