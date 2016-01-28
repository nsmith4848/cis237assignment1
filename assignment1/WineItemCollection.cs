using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        WineItem[] wineItemList = new WineItem[4000];             

        public string PrintEntireList()
        {
            string allOutput = "";
            foreach(WineItem wineItem in wineItemList)
            {
                if(wineItem != null)
                {
                    allOutput += wineItem.ToString() + Environment.NewLine;                    
                }
            }
            return allOutput;
        }
    }
}
