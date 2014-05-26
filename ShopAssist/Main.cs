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

        private order shopOrder = new order();       
        

        public MainForm()
        {
            InitializeComponent();
            shopOrder = new order();  

            //random items for testing.
            Item a = new Item("Apple", "001", 23);
            Item b = new Item("Banana", "001", 23);
            Item c = new Item("cake", "001", 23);
            Item d = new Item("Doily", "001", 23);
            Item e = new Item("Elephant", "001", 23);
            Item f = new Item("Grapes", "001", 23);

            shopOrder.addItem(a);
            shopOrder.addItem(b);
            shopOrder.addItem(c);
            shopOrder.addItem(d);
            shopOrder.addItem(e);
            shopOrder.addItem(f);

            MessageBox.Show(shopOrder.getItemList.Count().ToString() + " items added.");
            MessageBox.Show("Total price: $" + shopOrder.getTotalPrice());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool match = false;

            foreach (Item i in shopOrder.getItemList)
            {
                if (i.getName.ToUpper() == this.txtSearch.Text.ToUpper())
                {
                    match = true;
                    //ADD THE CODE FOR A MATCH

                    break;                 
                }                
            }
            MessageBox.Show(match.ToString());      
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
