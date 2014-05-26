using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopAssist
{
    class Item
    {
        private String itemID;
        private String name;
        private int qty;
        private int price;

        private Item()
        {
            qty = 0;
            price = 0;
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
    }
}
