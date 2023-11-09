using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gradevine;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zgrada zgrada = new Zgrada("asdf", "asdf");
            zgrada.Zone = new List<Zona>
            {
                new StambenaZona(),
                new StambenaZona(),
                new NeStambenaZona(),
            };
            zgrada.DodajNeStambeniProstor(new Prostor() { Povrsina = 100});
            zgrada.DodajNeStambeniProstor(new Prostor() { Povrsina = 200 });
            zgrada.DodajStambeniProstor(new Prostor() { Povrsina = 300 });
            Console.WriteLine(zgrada.Pricuva);
            Console.ReadLine();
        }
    }
}
