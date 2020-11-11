using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wojtas.Model
{
    public class Faktury
    {
        public int IdFaktury { get; set; }
        public int IdZamowienia { get; set; }
        public int Numer { get; set; }
    }
}
