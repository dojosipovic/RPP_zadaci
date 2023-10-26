using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljackaPloca
{
    internal class Vrata : IOtvor
    {
        public string Oznaka { get; set; }
        public StatusOtvora Status { get; set; }
        public bool Zakljucano { get; set; }

        public Vrata(string oznaka, bool zakljucano)
        {
            Oznaka = oznaka;
            Zakljucano = zakljucano;
            if (Zakljucano) Status = StatusOtvora.Zatvoren;
        }

        public void Otvori()
        {
            if (!Zakljucano)
                Status = StatusOtvora.Otvoren;
        }

        public void Zatvori()
        {
            Status = StatusOtvora.Zatvoren;
        }
    }
}
