using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class FiatConverter : ICurrencyConverter
    {
        public double Convert(Currency from, Currency to, double amount)
        {
            return (from.Rate / to.Rate) * amount * 0.98;
        }
    }
}
