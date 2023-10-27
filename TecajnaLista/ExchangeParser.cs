using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecajnaLista
{
    internal static class ExchangeParser
    {
        public static ExchangeRate ParseItem(string item)
        {
            var data = item.Split(';');
            return new ExchangeRate(data[0], double.Parse(data[1]));
        }
    }
}
