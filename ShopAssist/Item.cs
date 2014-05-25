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

        public Item()
        {

        }
        public void changeQuantity(int qtyDelta)
        {
            qty = qty + qtyDelta;
        }

        public int getPrice()
        {
            return price;
        }

        public int getQty()
        {
            return qty;
        }
    }
}
