using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecajnaLista
{
    internal class ExchangeRate
    {
        public string CurrencyName { get; set; }
        public double Rate { get; set; }
        public ExchangeRate(string currencyName, double rate)
        {
            CurrencyName = currencyName;
            Rate = rate;
        }
    }
}
