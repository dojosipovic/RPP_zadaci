using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingServis2
{
    internal class Film : VideoSadrzaj
    {
        public Film(string naziv, string opis) : base(naziv, opis)
        {
        }

        public int Trajanje { get; set; }

        public override string VratiInfo()
        {
            return $"{Naziv}, {Opis}, ({Trajanje} min)";
        }
    }
}
