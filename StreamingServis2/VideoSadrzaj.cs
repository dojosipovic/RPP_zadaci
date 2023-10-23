using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingServis2
{
    internal abstract class VideoSadrzaj
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public VrstaSadrzaja Vrsta { get; set; }

        public VideoSadrzaj(string naziv, string opis)
        {
            Naziv = naziv;
            Opis = opis;
        }

        public abstract string VratiInfo();
    }
}
