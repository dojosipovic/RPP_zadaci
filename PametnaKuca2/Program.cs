using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PametnaKuca2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SmartHouseSystem system = new SmartHouseSystem();

            Room room1 = new Room("kupaona")
            {
                Sensors = new List<Sensor>
                {
                    new TemperatureSensor(1, "asdf"),
                    new HumiditySensor(4, "asdf"),
                }
            };
            Room room2 = new Room("wc")
            {
                Sensors = new List<Sensor>
                {
                    new TemperatureSensor(2, "asdf"),
                    new HumiditySensor(5, "asdf"),
                }
            };
            Room room3 = new Room("dnevna")
            {
                Sensors = new List<Sensor>
                {
                    new TemperatureSensor(3, "asdf"),
                    new HumiditySensor(6, "asdf"),
                }
            };
            system.RoomList = new List<Room>()
            {
                room1, room2, room3
            };

            Console.WriteLine(system.GenerateReport());
            Console.ReadLine();
        }
    }
}
