using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    internal class HardwareItem : Item
    {
        public int Teza { get; set; }

        public HardwareItem()
        {
            //nič
        }

        public HardwareItem(string im, int price, int tez)
        {
            ItemName = im;
            Price = price;
            Teza = tez;
        }
        public new string ToString()
        {
            string podatki = ItemName + " " + Price + " " + Teza;
            return podatki;
        }
    }
}
