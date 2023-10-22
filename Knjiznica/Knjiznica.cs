using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica
{
    internal static class Knjiznica
    {
        public static Clan DodajClana(string ime, string prezime)
        {
            Clan noviClan = null;

            if (!ClanoviRepozitorij.Sadrzi(ime, prezime))
            {
                noviClan = new Clan(ime, prezime);
                ClanoviRepozitorij.Spremi(noviClan);
            }

            return noviClan;
        }
    }
}
