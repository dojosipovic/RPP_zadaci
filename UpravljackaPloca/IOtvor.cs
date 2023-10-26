using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpravljackaPloca
{
    public enum StatusOtvora
    {
        Otvoren,
        Zatvoren
    }
    internal interface IOtvor
    {
        string Oznaka { get; set; }
        StatusOtvora Status { get; set; }

        void Otvori();
        void Zatvori();
    }
}
