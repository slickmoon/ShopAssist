using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopAssist
{
    class itemList
    {
        private List<Item> listOfItems = new List<Item>();

        public void addItem(Item item)
        {
            if (!listOfItems.Contains(item))
            {
                listOfItems.Add(item);
            }
            else
            {
                item.changeQuantity(1);   
            }
        }

        public void removeItem(Item item)
        {
            listOfItems.Remove(item);
        }

        public List<Item> getItemList()
        {
            return listOfItems;
        }
    }
}