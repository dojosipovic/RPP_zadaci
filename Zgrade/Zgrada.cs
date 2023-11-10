using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zgrade
{
    internal class Zgrada
    {
        private string _oznaka;
        private string _adresa;

        public string Oznaka {
            get
            {
                return _oznaka;
            }
            set
            {
                if (value != "" && value != null)
                {
                    _oznaka = value;
                }
            }
        }
        public string Adresa
        {
            get
            {
                return _adresa;
            }
            set
            {
                if (value != "" && value != null)
                {
                    _adresa = value;
                }
            }
        }
        public List<Prostor> Prostori { get; set; }

        public Zgrada(string oznaka, string adresa)
        {
            _oznaka = oznaka;
            Adresa = adresa;
        }

        public bool ProdajProstor(string oznaka)
        {
            var p = Prostori.Find(x => x.Oznaka == oznaka);
            if (p == null) return false;
            if (!p.Slobodan) return false;

            p.Slobodan = false;
            return true;
        }

        public List<Prostor> DohvatiSlobodneProstore()
        {
            return Prostori.FindAll(x => x.Slobodan == true).OrderBy(x => x.Cijena).ToList();
        }

        public List<Prostor> DohvatiNeSlobodneProstore()
        {
            return Prostori.FindAll(x => x.Slobodan == false);
        }

        public List<Prostor> DohvatiProstoreManjeOd(double cijena)
        {
            return Prostori.FindAll(x => x.Cijena < cijena);
        }

        public List<NeStambeniProstor> DohvatiNestambeneProstore(double cijena)
        {
            return Prostori.OfType<NeStambeniProstor>().ToList();
        }
    }
}
