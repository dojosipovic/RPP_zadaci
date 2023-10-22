using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingServis
{
    internal class PogledaniFilm
    {
        public int Id { get; set; }
        public DateTime DatumGledanja { get; set; }
        public PogledaniFilm(int idFilma)
        {
            Id = idFilma;
            DatumGledanja = DateTime.Now;
        }
    }
}
