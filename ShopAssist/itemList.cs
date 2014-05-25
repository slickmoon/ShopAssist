using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopAssist
{
    class itemList
    {
        private List<Item> itemList = new List<Item>();

        public void addItem(Item item)
        {
            if (!itemList.Contains(item))
            {
                itemList.Add(item);
            }
            else
            {
                item.changeQuantity(1);   
            }
        }

        public void removeItem(Item item)
        {
            itemList.Remove(item);
        }
    }
}