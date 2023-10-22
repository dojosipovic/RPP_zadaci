using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelskeSobe
{
    internal static class Recepcija
    {
        public static List<Rezervacija> Rezervacije = new List<Rezervacija>();
        public static List<HotelskaSoba> DohvatiSlobodneSobe(DateTime datum)
        {
            var sveSobe = Hotel.DohvatiSveSobe();
            var slobodneSobe = new List<HotelskaSoba>();

            foreach (var s in sveSobe)
            {
                var rezervacija = Rezervacije
                    .Find(x => x.Soba.Oznaka == s.Oznaka && x.datumRezervacije == datum);
                if (rezervacija == null){
                    slobodneSobe.Add(s);
                }
            }

            return slobodneSobe;
        }

        public static void Rezerviraj(HotelskaSoba soba, DateTime datum)
        {
            Rezervacije.Add(new Rezervacija(soba, datum));
        }
    }
}
