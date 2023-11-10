using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrgovinskiRacun
{
    internal class TradingAccount
    {
        public string AccNumber { get; set; }
        public List<Wallet> Wallets { get; set; } = new List<Wallet>();

        public TradingAccount(string accNumber)
        {
            AccNumber = accNumber;
        }

        public double GlobalAmount()
        {
            return Wallets.Sum(x => x.AmountInHrk());
        }
    }
}
