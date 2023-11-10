namespace Zgrade
{
    public abstract class Prostor
    {
        protected double _cijena { get; set; }
        public string Oznaka { get; }
        public int Kat { get; }
        public double Povrsina { get; }
        public double Cijena
        {
            get
            {
                return _cijena;
            }
            set
            {
                if (value >= 0)
                {
                    _cijena = value;
                }
            }
        }
        public bool Slobodan
        {
            get; set;
        }

        public Prostor(string oznaka, int kat, double pov)
        {
            Oznaka = oznaka;
            Kat = kat;
            Povrsina = pov;
        }

        public virtual double IzracunajCijenu() => Povrsina * _cijena;
    }
}