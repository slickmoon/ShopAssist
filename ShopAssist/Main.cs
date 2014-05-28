using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ShopAssist
{
    public partial class MainForm : Form
    {

        private order shopOrder;
        private SearchResult resultPage;
        private OrderPage orderSelect;
        

        public MainForm()
        {
            InitializeComponent();
            shopOrder = new order();  

            //random items for testing.
            Item a = new Item("Apple Elephant", "001", 23);
            Item b = new Item("Banana", "002", 24);
            Item c = new Item("cake", "003", 58);
            Item d = new Item("Apple", "004", 13);
            Item e = new Item("Elephant", "005", 30);
            Item f = new Item("Grapes", "006", 16);
            Item g = new Item("Lollies", "007", 4);
            Item h = new Item("Chocolate", "008", 3);
            Item i = new Item("12kg Black Tar Heroin", "009", 3000);
            Item j = new Item("Shampoo", "010", 70);
            Item k = new Item("Conditioner", "011", 27);
            Item l = new Item("Laptop", "012", 1236);
            Item m = new Item("TV", "013", 9999);

            shopOrder.addItem(a);
            shopOrder.addItem(b);
            shopOrder.addItem(c);
            shopOrder.addItem(d);
            shopOrder.addItem(e);
            shopOrder.addItem(f);
            shopOrder.addItem(g);
            shopOrder.addItem(h);
            shopOrder.addItem(i);
            shopOrder.addItem(j);
            shopOrder.addItem(k);
            shopOrder.addItem(l);
            shopOrder.addItem(m);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int flag = 0;
            itemList temp = new itemList();
            string[] searcharray = this.txtSearch.Text.ToUpper().Split(null);
            //looping through every item in the list
            foreach (Item i in shopOrder.getItemList)
            {
                flag = 0;
                //splitting the name into an array based on the whitespace
                //EG: "Apple Juice" becomes "APPLE", "JUICE" for testing
                string itemname = i.getName.ToUpper();
                string[] testarray = itemname.Split(null);
                //testing each term in the item name
                foreach (string testname in testarray)
                {
                    //testing each term in search query
                    foreach (string search in searcharray)
                    {
                        if (testname == search)
                        {
                            //when a match is found, add the current item to the temporary list for search output
                            temp.addItem(i);
                            //flag is used to break out of the matching loop so that we move to the next item once a match has been found
                            flag = 1;
                            break;
                        }
                    }
                    //flag is used to move onto the next item in the list
                    if (flag == 1)
                    {
                        break;
                    }
                }
            }
            resultPage = new SearchResult(temp, this.txtSearch.Text);
            resultPage.Show();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            orderSelect = new OrderPage();
            orderSelect.Show();
        }
    }
}
