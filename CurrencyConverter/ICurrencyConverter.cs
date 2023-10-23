using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal interface ICurrencyConverter
    {
        double Convert(Currency from, Currency to, double amount);
    }
}
