using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingServis2
{
    internal class Serija : VideoSadrzaj
    {
        public List<Sezona> Sezone { get; set; }

        public Serija(string naziv, string opis) : base(naziv, opis)
        {
        }

        public override string VratiInfo()
        {
            var info = $"{Naziv} ({Sezone.Count} sezone),\n";
            foreach (var sezona in Sezone)
            {
                info += $"Sezona {sezona.RedniBroj} ({sezona.Epizode.Count} epizoda),\n";
            }
            return info;
        }
    }
}
