using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class Item
    {
        // public int Id { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int Sifra { get; set; }
        /* public int Licencekay { get; set; }
         public int SizeMB { get; set; }
         public int Verzija { get; set; }
         public int Teza { get; set; }
         public int Noofcores { get; set; }
         public int Amountofram { get; set; }
         public int Hddsize { get; set; }
         public int Resolucija { get; set; }
         public string Tipmonitorja { get; set; }*/

        //..
        //konstruktorji 
        public Item()
        {
            //nič
        }
        public Item(string itemname, int price) : this()
        {
            //ItemID = itemid;
            ItemName = itemname;
            Price = price;

        }
        public new string ToString()
        {
            string podatki = ItemID + " " + ItemName + " " + Price + " " + Sifra;
            return podatki;
        }
    }
}
