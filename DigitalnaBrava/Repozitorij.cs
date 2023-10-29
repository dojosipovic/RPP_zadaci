using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalnaBrava
{
    internal static class Repozitorij
    {
        private static List<Korisnik> korisnici = new List<Korisnik>()
        {
            new Korisnik { BrojKartice = 10001, PIN = 1234, RazinaPrava = 1 },
            new Korisnik { BrojKartice = 10002, PIN = 0000, RazinaPrava = 2 },
            new Korisnik { BrojKartice = 10003, PIN = 9999, RazinaPrava = 2 },
        };
        private static List<Vrata> vrata = new List<Vrata>()
        {
            new Vrata { BrojVrata = 501, RazinaPrava = 1 },
            new Vrata { BrojVrata = 502, RazinaPrava = 2 },
            new Vrata { BrojVrata = 503, RazinaPrava = 2 },
        };

        public static Korisnik DohvatiKorisnika(int brKartice, int pin)
        {
            return korisnici.Find(x => x.BrojKartice == brKartice && x.PIN == pin);
        }
        public static Vrata DohvatiVrata(int brVrata)
        {
            return vrata.Find(x => x.BrojVrata == brVrata);
        }
    }
}
