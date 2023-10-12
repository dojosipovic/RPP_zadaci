using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter.Classes
{
    public class Currency
    {
        public string Name { get; set; }
        public double Exchange { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
