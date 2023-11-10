using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TrgovinskiRacun
{
    public static class Exchange
    {
        public static double GetHrkRate(Currency currency)
        {
            if (currency == Currency.USD) return 7.04215;
            if (currency == Currency.EUR) return 7.5345;
            if (currency == Currency.HRK) return 1;

            throw new NotImplementedException();
        }

        public static double GetBtcRate(CryptoCurrency crypto)
        {
            if (crypto == CryptoCurrency.BTC) return 1;
            if (crypto == CryptoCurrency.ETH) return 0.056;
            if (crypto == CryptoCurrency.XRP) return 0.000018;

            throw new NotImplementedException();
        }

        public static double GetBtcRateInHrk() => 263325.39;
    }
}
