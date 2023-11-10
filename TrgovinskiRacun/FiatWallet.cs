using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrgovinskiRacun
{
    public sealed class FiatWallet : Wallet
    {
        public FiatWallet(double amount, Currency curr) : base(amount, curr)
        {
        }

        public override double AmountInHrk()
        {
            double rateInHrk = Exchange.GetHrkRate(Currency);
            return Amount * rateInHrk;
        }
    }
}
