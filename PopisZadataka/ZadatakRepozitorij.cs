using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopisZadataka
{
    internal static class ZadatakRepozitorij
    {
        public static List<Zadatak> Zadaci = new List<Zadatak>();
        public static List<Zadatak> DohvatiZadatke()
        {
            return Zadaci;
        }
        public static void DodajZadatak(string naziv, DateTime rok)
        {
            Zadaci.Add(new Zadatak(naziv, rok));
            Console.WriteLine(Zadaci.Count);
        }
    }
}
