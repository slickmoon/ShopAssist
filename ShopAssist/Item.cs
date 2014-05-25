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

        public Item()
        {

        }
        public void changeQuantity(int qtyDelta)
        {
            qty = qty + qtyDelta;
        }
    }
}
