using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonverzijaValuta
{
    internal class Currency
    {
        public string Name { get; set; }
        public double ExchangeRate { get; set; }

        public double ConvertTo(Currency currency, double amount)
        {
            return amount * ExchangeRate / currency.ExchangeRate;
        }
    }
}
