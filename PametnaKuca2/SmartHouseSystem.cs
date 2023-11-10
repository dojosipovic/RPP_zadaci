using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PametnaKuca2
{
    internal class SmartHouseSystem
    {
        public List<Room> RoomList { get; set; } = new List<Room>();
        public string GenerateReport()
        {
            string report = "";

            RoomList.ForEach(room => report += $"Parameter for room {room.Name}\n{room.GenerateTextualReport()}\n");

            return report;
        }
    }
}
