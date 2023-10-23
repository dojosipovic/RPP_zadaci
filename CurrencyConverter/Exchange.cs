using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class Exchange
    {
        public ICurrencyConverter GetConverter(Currency from, Currency to)
        {
            if (from.Type == CurrencyType.Fiat && to.Type == CurrencyType.Fiat)
            {
                return new FiatConverter();
            }
            else if (from.Type == CurrencyType.Crypto && to.Type == CurrencyType.Crypto)
            {
                return new CryptoConverter();
            }

            throw new NotSupportedException();
        }

        public double Convert(Currency from, Currency to, double amount)
        {
            return GetConverter(from, to).Convert(from, to, amount);
        }
    }
}
