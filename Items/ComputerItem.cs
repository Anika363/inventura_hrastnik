using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    internal class ComputerItem : HardwareItem
    {
        public int Noofcores { get; set; }
        public int Amountofram { get; set; }
        public int Hddsize { get; set; }

        public ComputerItem()
        {
            //nič
        }
        public ComputerItem(string im, int price, int tez, int core, int ram, int hdd)
        {
            ItemName = im;
            Price = price;
            Teza = tez;
            Noofcores = core;
            Amountofram = ram;
            Hddsize = hdd;
        }
    }
}
