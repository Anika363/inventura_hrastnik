using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    internal class SoftwareItem : Item
    {
        public int Licencekay { get; set; }
        public int SizeMB { get; set; }
        public int Verzija { get; set; }

        public SoftwareItem()
        {
            //nič
        }
        public SoftwareItem(string im, int price, int licence, int mb, int verz)
        {
            ItemName = im;
            Price = price;
            Licencekay = licence;
            SizeMB = mb;
            Verzija = verz;
        }
        public new string ToString()
        {
            string podatki = Licencekay + " " + SizeMB + " " + Verzija;
            return podatki;
        }
    }
}
