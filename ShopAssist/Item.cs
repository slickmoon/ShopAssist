using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopAssist
{
    public class Item
    {
        private String itemID;
        private String name;
        private int qty;
        private int price;

        public Item(String Name, string ID, int Price)
        {
            itemID = ID;
            price = Price;
            name = Name;
            qty = 0;

        }
        public void changeQuantity(int qtyDelta)
        {
            qty = qty + qtyDelta;
        }

        public int getPrice
        {
            get{ return price; }
        }

        public int getQty
        {
            get{ return qty; }
        }

        public string getName
        {
            get { return name; }
        }
    }
}
