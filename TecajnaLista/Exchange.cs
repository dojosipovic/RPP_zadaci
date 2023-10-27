using BankLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecajnaLista
{
    internal class Exchange
    {
        public List<ExchangeRate> GetExchangeRates()
        {
            return BankAPI.GetExchangeData()
                .Select(x => ExchangeParser.ParseItem(x))
                .ToList();
        }
    }
}
