using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopAssist
{
    class watchList : itemList
    {
        private List<string> email = new List<string>();

        private void notifyUser(List<string> email)
        {
            //Loop through emails and send to them via POP
        }
    }
}
