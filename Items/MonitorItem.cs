using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    internal class MonitorItem : HardwareItem
    {
        public int Resolucija { get; set; }
        public string Tipmonitorja { get; set; }

        public MonitorItem()
        {
            //nič
        }
        public MonitorItem(string im, int price, int tez, int res, string tip)
        {
            ItemName = im;
            Price = price;
            Teza = tez;
            Resolucija = res;
            Tipmonitorja = tip;
        }
        public new string ToString()
        {
            string podatki = Resolucija + " " + Tipmonitorja;
            return podatki;
        }
    }
}
