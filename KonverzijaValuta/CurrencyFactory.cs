using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonverzijaValuta
{
    internal static class CurrencyFactory
    {
        public static List<Currency> currencies = new List<Currency>()
        {
            new Currency { Name = "HRK", ExchangeRate = 1 },
            new Currency { Name = "EUR", ExchangeRate = 7.4 },
            new Currency { Name = "USD", ExchangeRate = 6.5 },
            new Currency { Name = "GBP", ExchangeRate = 8.5 },
            new Currency { Name = "CAD", ExchangeRate = 4.9 }
        };

        public static Currency GetCurrency(string currName)
        {
            return currencies.Find(x => x.Name == currName);
        }

        public static List<string> GetNames()
        {
            var names = new List<string>();
            foreach (var currency in currencies)
            {
                names.Add(currency.Name);
            }

            return names;
        }
    }
}
