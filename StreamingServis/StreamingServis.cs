using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingServis
{
    internal static class StreamingServis
    {
        public static List<Film> DohvatiNeodgledaneFilmove()
        {
            var sviFilmovi = KatalogFilmova.DohvatiSveFilmove();
            var pogledaniFilmovi = KatalogFilmova.DohvatiPogledanefilmove();
            var neodgledaniFilmovi = new List<Film>();

            foreach(var f in sviFilmovi)
            {
                if (pogledaniFilmovi.Find(x => x.Id == f.Id) == null)
                {
                    neodgledaniFilmovi.Add(f);
                }
            }

            return neodgledaniFilmovi;
        }

        public static void PogledajFilm(Film odabraniFilm)
        {
            var noviPogledaniFilm = new PogledaniFilm(odabraniFilm.Id);
            KatalogFilmova.DodajPogledaniFilm(noviPogledaniFilm);
        }
    }
}
