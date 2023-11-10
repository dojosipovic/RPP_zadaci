using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrgovinskiRacun
{
    public class CryptoWallet : Wallet
    {
        public CryptoCurrency Currency { get; set; }
        public CryptoWallet(double amount, Currency curr) : base(amount, curr)
        {
        }

        public override double AmountInHrk()
        {
            double rateInBtc = Exchange.GetBtcRate(Currency);
            double rateInHrk = Exchange.GetBtcRateInHrk();
            return Amount * rateInBtc * rateInHrk;
        }
    }
}
