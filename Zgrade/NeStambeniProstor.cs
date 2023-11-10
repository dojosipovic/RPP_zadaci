using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zgrade
{
    internal class NeStambeniProstor : Prostor
    {
        public NeStambeniProstor(string oznaka, int kat, double pov) : base(oznaka, kat, pov)
        {
        }

        public override double IzracunajCijenu()
        {
            return Povrsina * _cijena * 1.03;
        }
    }
}
