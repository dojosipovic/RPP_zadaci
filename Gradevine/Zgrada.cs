using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradevine
{
    public class Zgrada
    {
        public string Oznaka { get; }
        public string Adresa { get; }
        public List<Zona> Zone { get; set; }
        public int Pricuva
        {
            get
            {
                return Zone.Sum(x => x.Pricuva);
            }
        }

        public Zgrada(string oznaka, string adresa)
        {
            Oznaka = oznaka;
            Adresa = adresa;
        }

        public void DodajStambeniProstor(Prostor prostor)
        {
            Zone.OfType<StambenaZona>().Last().Prostori.Add(prostor);
        }

        public void DodajNeStambeniProstor(Prostor prostor)
        {
            Zone.OfType<NeStambenaZona>().Last().Prostori.Add(prostor);
        }

        public List<Prostor> DohvatiListuProstoraZgrade()
        {
            return Zone.SelectMany(x => x.Prostori).ToList();
        }
    }
}
