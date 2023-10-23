using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public enum CurrencyType
    {
        Fiat,
        Crypto
    }
    internal abstract class Currency
    {
        public string Name { get; set; }
        public CurrencyType Type { get; set; }
        public double Rate { get; set; }

        public Currency(string name, CurrencyType type, double rate)
        {
            Name = name;
            Type = type;
            Rate = rate;
        }
    }
}
