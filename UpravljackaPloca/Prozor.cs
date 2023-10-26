using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljackaPloca
{
    internal class Prozor : IOtvor
    {
        public string Oznaka { get; set; }
        public StatusOtvora Status { get; set; }

        public Prozor(string oznaka)
        {
            Oznaka = oznaka;
        }
        public void Otvori()
        {
            Status = StatusOtvora.Otvoren;
        }

        public void Zatvori()
        {
            Status = StatusOtvora.Zatvoren;
        }
    }
}
