using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wojtas.Model
{
    public class Zamowienia
    {
        public int IdZamowienia { get; set; }
        public int IdKlienta { get; set; }
        public double WartoscZamowienia { get; set; }
    }
}
