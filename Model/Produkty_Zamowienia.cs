using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wojtas.Model
{
    public class Produkty_Zamowienia
    {
        public int IdZamowienia { get; set; }
        public int IdProduktu { get; set; }
        public int Ilosc { get; set; }
    }
}
