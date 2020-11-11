using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wojtas.Model;

namespace Wojtas
{
    public class Program
    {
        public static List<Produkty> Products { get; set; } = new List<Produkty>();
        public static List<Klienci> Klients { get; set; } = new List<Klienci>();
        public int lastId;

        static void Main(string[] args)
        {
            Program prog = new Program();
            Products.Add(new Produkty()
            {
                IdProduktu = 0,
                Nazwa = "Parowki",
                Cena = 10.0
            });
            Products.Add(new Produkty()
            {
                IdProduktu = 1,
                Nazwa = "Japko",
                Cena = 2.0
            });
            Products.Add(new Produkty()
            {
                IdProduktu = 2,
                Nazwa = "Cebula",
                Cena = 1.0
            });
            Klients.Add(new Klienci()
            {
                IdKlienta = 0,
                Imie = "Janusz",
                Nazwisko = "Cebularz"
            });
            Klients.Add(new Klienci()
            {
                IdKlienta = 0,
                Imie = "Grażyna",
                Nazwisko = "Siuzdak"
            });
            prog.Odczyt("Zamowienia_Produkty.txt");
            Console.WriteLine("-----------------------");
            prog.GetLastId("Zamowienia_Produkty.txt");
            prog.Zapis("Zamowienia_Produkty.txt", Products.First(x => x.IdProduktu == 2).IdProduktu, 10);
            Console.WriteLine("-----------------------------SS-----------------");
            prog.Odczyt("Zamowienia_Produkty.txt");
            Console.ReadKey();
        }

        public void GetLastId(string tabela)
        {
            using StreamReader sr = new StreamReader(tabela);
            string line;
            List<string> lines = new List<string>();
            while ((line = sr.ReadLine()) != null)
            {
                lines.Add(line);
            }

            var lastLine = lines.Last();
            int indexOfEqual = lastLine.IndexOf("=");
            string lastIdString = lastLine.Substring(indexOfEqual + 1, 1);
            int lastIdNumber;
            bool succes = int.TryParse(lastIdString, out lastId);
            Console.WriteLine(lastId);
            sr.Close();
        }

        public void Odczyt(string tabela)
        {
            using StreamReader sr = new StreamReader(tabela);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);

            }
            sr.Close();
        }
        public void Zapis(string tabela, int idProduktu, int ilosc)
        {
            using (StreamReader sr = new StreamReader(tabela))
            {
                using StreamWriter sw = new StreamWriter(tabela);
                if (lastId != null)
                {
                    sw.WriteLine($"IdZamowienia={lastId + 1},IdProduktu={idProduktu},Ilosc={ilosc}");
                }
            }
        }
    }
}
