using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            CSVProcessor csvProcessor = new CSVProcessor();
            WineItemCollection wineItemCollection = new WineItemCollection();
            UserInterface ui = new UserInterface();
            int choice = ui.Interact();
            while (choice != 5)
            {
                if(choice == 1)
                {
                    csvProcessor.ProcessCSV("../datafiles/WineList.csv",wineItemCollection);
                }
                if(choice == 2)
                {
                    string bigListString = wineItemCollection.PrintEntireList();
                    ui.PrintAllOutput(bigListString);
                }
                if (choice == 3)
                {

                }
                if (choice == 4)
                {

                }
            }
        }
    }
}
