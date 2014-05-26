using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopAssist
{
    class order: itemList
    {
        private string orderID;
        private string orderDate;
        private itemList listOfItems;

        private Item getItem(int idx)
        {
            return listOfItems.getItemList[idx];
        }

        public int getTotalPrice()
        {
            int price = 0;

            foreach (Item i in listOfItems.getItemList)
            {
                if (i.getQty == 1)
                {
                    price = price + i.getPrice;
                }

                else
                {
                    price = price + (i.getPrice * i.getQty);
                }
            
            }

            return price;
        }

        public string getDate
        {
            get{ return orderDate; }
        }
    }
}
