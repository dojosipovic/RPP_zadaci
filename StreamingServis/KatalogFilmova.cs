using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingServis
{
    internal static class KatalogFilmova
    {
        public static List<PogledaniFilm> Pogledani = new List<PogledaniFilm>();
        public static List<Film> Filmovi = new List<Film>()
        {
            new Film { Id = 1, Naziv = "Batman" },
            new Film { Id = 2, Naziv = "Superman" },
            new Film { Id = 3, Naziv = "Spiderman" },
            new Film { Id = 4, Naziv = "Ironman" },
            new Film { Id = 5, Naziv = "Hulk" }
        };

        public static List<Film> DohvatiSveFilmove()
        {
            return Filmovi;
        }
        public static List<PogledaniFilm> DohvatiPogledanefilmove()
        {
            return Pogledani;
        }
        public static void DodajPogledaniFilm(PogledaniFilm noviPogledaniFilm)
        {
            Pogledani.Add(noviPogledaniFilm);
        }
    }
}
