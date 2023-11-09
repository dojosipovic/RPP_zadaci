using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradevine
{
    public abstract class Zona
    {
        public string Oznaka { get; set; }
        public List<Prostor> Prostori { get; set; } = new List<Prostor>();
        protected int Povrsina { get => Prostori.Sum(x => x.Povrsina); }
        public int Pricuva { get => IzracunajPricuvu(); }

        public abstract int IzracunajPricuvu();
    }
}
