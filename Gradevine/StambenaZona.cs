using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradevine
{
    public class StambenaZona : Zona
    {
        public override int IzracunajPricuvu()
        {
            return Povrsina * 2;
        }
    }
}
