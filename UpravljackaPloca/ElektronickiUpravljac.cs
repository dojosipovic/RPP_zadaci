using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljackaPloca
{
    internal class ElektronickiUpravljac
    {
        public List<IOtvor> Otvori { get; set; }

        public ElektronickiUpravljac()
        {
            Otvori = new List<IOtvor>();
            Otvori.Add(new Prozor("Prozor 1 JZ"));
            Otvori.Add(new Prozor("Prozor 2 JZ"));
            Otvori.Add(new Prozor("Prozor 3 JI"));
            Otvori.Add(new Vrata("Balkonska vrata", false));
            Otvori.Add(new Vrata("Ulazna vrata", true));
        }

        public void OtvoriOtvor(string oznaka) => Otvori.Find(x => x.Oznaka == oznaka).Otvori();
        public void ZatvoriOtvor(string oznaka) => Otvori.Find(x => x.Oznaka == oznaka).Zatvori();
        public void ZatvoriSve() => Otvori.ForEach(x => x.Zatvori());
        public void OtvoriSve() => Otvori.ForEach(x => x.Otvori());
    }
}
