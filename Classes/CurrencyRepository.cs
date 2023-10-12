using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoneyConverter.Classes
{
    public class CurrencyRepository
    {
        public static List<Currency> currencies = new List<Currency>()
        {
            new Currency { Name = "HRK", Exchange = 1 },
            new Currency { Name = "EUR", Exchange = 7.4 },
            new Currency { Name = "USD", Exchange = 6.5 },
            new Currency { Name = "GBP", Exchange = 8.5 },
            new Currency { Name = "CAD", Exchange = 4.9 }
        };
    }
}
