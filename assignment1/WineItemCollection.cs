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

        //Public Method to get the entire list as a string
        public string PrintEntireList()
        {
            string allOutput = "";
            foreach(WineItem wineItem in wineItemList)           //Prints off every record into a single, readable string
            {
                if(wineItem != null)
                {
                    allOutput += wineItem.ToString() + Environment.NewLine;                    
                }
            }
            return allOutput;                                   //Returns said string
        }

        public void ProcessCSV()                                 //Used to allow the CSVProcessor class to use the array
        {
            CSVProcessor csvProcessor = new CSVProcessor();
            csvProcessor.ProcessCSV("../datafiles/WineList.csv", wineItemList);            //Incorrect path, I'm not sure what the correct one is
        }

        public string SearchForWineItem(string searchIDNumber)                      //Used to find the searched ID Number's corresponding record, sends back null if not found
        {                  
            for(int i = 0; i < wineItemList.Length; i++)                              //Linear search using a loop
            {
                if(wineItemList[i].IDNumberString == searchIDNumber)
                {
                    return wineItemList[i].ToString();
                }
            }

            return null;
        }

        public void AddRecord(WineItem addedRecord)             //Adds record to end of full array using a for loop
        {
            int counter = 0;
            for(counter = 0; counter < wineItemList.Length; counter++)
            {
                if(wineItemList[counter] == null)
                {
                    wineItemList[counter] = addedRecord;
                    return;
                }
            }            
        }
    }
}
