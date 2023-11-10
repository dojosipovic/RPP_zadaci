namespace TrgovinskiRacun
{
    public abstract class Wallet
    {
        public double Amount { get; set; }
        public Currency Currency { get; set; }

        public Wallet(double amount, Currency curr)
        {
            Amount = amount;
            Currency = curr;
        }

        public abstract double AmountInHrk();
    }
}