using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    internal static class ClanoviRepozitorij
    {
        public static List<Clan> Clanovi = new List<Clan>();
        public static bool Sadrzi(string ime, string prezime)
        {
            var clan = Clanovi.Find(x => x.Ime == ime && x.Prezime == prezime);
            return clan != null;
        }
        public static void Spremi(Clan noviClan)
        {
            var korime = GenerirajKorisnickoIme(noviClan);
            var lozinka = GenerirajLozinku();
            noviClan.SetKorisnickoIme(korime);
            noviClan.SetLozinka(lozinka);

            Clanovi.Add(noviClan);
        }

        private static string GenerirajKorisnickoIme(Clan noviClan)
        {
            int min = 5, max = 10;
            var korime = noviClan.Ime[0] + noviClan.Prezime;
            var random = new Random();

            while (korime.Length < min) korime += random.Next(9);
            if (korime.Length > max) korime = korime.Substring(0, max);

            return korime.ToLower();
        }

        private static string GenerirajLozinku()
        {
            return new Random().Next(1000, 9999).ToString();
        }
    }
}
