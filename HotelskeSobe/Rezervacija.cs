using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe
{
    internal class Rezervacija
    {
        public HotelskaSoba Soba { get; set; }
        public DateTime datumRezervacije { get; set; }

        public Rezervacija(HotelskaSoba soba, DateTime datum)
        {
            Soba = soba;
            datumRezervacije = datum;
        }
    }
}
