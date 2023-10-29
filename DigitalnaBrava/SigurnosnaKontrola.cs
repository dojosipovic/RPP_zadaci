using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalnaBrava
{
    internal static class SigurnosnaKontrola
    {
        public static bool OtvoriVrata(int brKartice, int pin, int brVrata)
        {
            var korisnik = Repozitorij.DohvatiKorisnika(brKartice, pin);
            var vrata = Repozitorij.DohvatiVrata(brVrata);

            return (korisnik == null || vrata == null) ?
                false : ImaPrava(korisnik, vrata);
        }

        private static bool ImaPrava(Korisnik korisnik, Vrata vrata)
        {
            return korisnik.RazinaPrava >= vrata.RazinaPrava;
        }
    }
}
