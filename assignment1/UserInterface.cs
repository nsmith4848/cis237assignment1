using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        public int Interact()
        {
            this.PrintOptions();        //Prints options menu to the console
            String input = Console.ReadLine();
            while(input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                //Give them a prompt to rethink their last choice
                Console.WriteLine("That is not a valid entry");
                Console.WriteLine("Please make a valid choice");
                Console.WriteLine();
                //Reprint the menu for the user
                this.PrintOptions();
                //Accept their next input
                input = Console.ReadLine();
            }
            return Int32.Parse(input);       //Returns option selected
        }

        public void PrintAllOutput(string allOutput)    //Prints all records in the WineItemList array
        {
            Console.WriteLine(allOutput);
            Console.WriteLine("Enter a key to continue");
            Console.ReadKey();
        }

        private void PrintOptions()                   //Used to Print the menu
        {
            Console.WriteLine("What would you like to do?" + Environment.NewLine +
                "1.  Load the Wine List File(WARNING: This Can Only Be Done Once!)" + Environment.NewLine +
                "2.  Print the List" + Environment.NewLine +
                "3.  Search and Display Item by Item ID" + Environment.NewLine +
                "4.  Add A new Item to the list" + Environment.NewLine +
                "5.  Exit the Program" + Environment.NewLine);
        }

        public void AlreadyDidThat()                           //Used to tell the user that they already loaded the csv file
        {
            Console.WriteLine("You have already loaded this list");
        }

        public string SearchForRecord()                       //Gets input ID number from the user
        {
            Console.WriteLine("Please enter the ID Number that you wish to search for");

            string searchIDNumber = Console.ReadLine();

            return searchIDNumber;
            
        }

        public void WrongSearch(string searchedIDString)                       //Tells user that their ID number was not in the array
        {
            Console.WriteLine("I'm Sorry, but we could not match the ID Number " + searchedIDString + " to our records");
        }

        public void SuccessfulSearch(string searchedWineItem)              //Shows record of User's correct ID number
        {
            Console.WriteLine("We found the record!" + Environment.NewLine + searchedWineItem);
        }

        public WineItem InputRecord()                                  //Prompts user to Input ID number, item name, and item quantity for the record they wish to add
        {
            WineItem MadeRecord = new WineItem();
            Console.WriteLine("Please Input the ID Number");
            MadeRecord.IDNumberString = Console.ReadLine();
            Console.WriteLine("Please Input the item Name");
            MadeRecord.ItemNameString = Console.ReadLine();
            Console.WriteLine("Please Input the Quantity It Sells In");
            MadeRecord.QuantityString = Console.ReadLine();
            Console.WriteLine("Your Record has been added");
            return MadeRecord;
        }
    }
}
