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
    public partial class SearchResult : Form
    {
        private itemList searchResults = new itemList();

        public SearchResult(itemList inputResults, string terms)
        {
            InitializeComponent();
            //pass in search results to local variable
            searchResults = inputResults;
            //loads the form boxes with information provided
            LoadBoxes(terms);
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            //Dunno what this will do, likely nothing
        }

        private void LoadBoxes(string header)
        {
            List<string> temp = new List<string>();
            List<int> intTemp = new List<int>();
            
            //adding search terms to heading
            lblHeading.Text = ("Search Results for '" + header + "'");
            //if the list is not empty
            if (searchResults.getItemList.Count() != 0)
            {
                //Clear the undefined information and print item names and prices
                lstResults.ClearSelected();
                foreach (Item i in searchResults.getItemList)
                {
                    temp.Add(i.getName);
                    intTemp.Add(i.getPrice);
                }
                lstPrice.DataSource = intTemp;
            }
            else
            {
                temp.Add("No items found");
            }
            lstResults.DataSource = temp;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnViewSelected_Click(object sender, EventArgs e)
        {
            //Code for viewing selected item
            //Text box needs to be altered to make items selectable
            //Perhaps a listbox rather than a textbox
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSortPrice_Click(object sender, EventArgs e)
        {

        }
        
        //Accessor for search result list
        //DEPRECIATED, ONLY USE FOR TESTING
        //public itemList SearchResults
        //{
        //    get { return searchResults; }
        //    set { searchResults = value; }
        //}
       }
}
