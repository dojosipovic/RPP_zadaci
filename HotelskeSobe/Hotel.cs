using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe
{
    internal static class Hotel
    {
        private static List<HotelskaSoba> SveSobe = new List<HotelskaSoba>()
        {
            new HotelskaSoba(){ Oznaka = 501, Kapacitet = 3 },
            new HotelskaSoba(){ Oznaka = 502, Kapacitet = 2 },
            new HotelskaSoba(){ Oznaka = 503, Kapacitet = 5 },
            new HotelskaSoba(){ Oznaka = 504, Kapacitet = 2 }
        };

        public static List<HotelskaSoba> DohvatiSveSobe()
        {
            return SveSobe;
        }
    }
}
