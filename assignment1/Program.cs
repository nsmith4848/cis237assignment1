using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {                        
            bool beenThere = true;          //Boolean used to tell whether or not the csv file has been loaded

            WineItemCollection wineItemCollection = new WineItemCollection();             //Instantiate the other classes
            UserInterface ui = new UserInterface();
            int choice = ui.Interact();                 //Loads Menu
            while (choice != 5)                            //Validates Whether or not the user chose to exit
            {
                if(choice == 1)                          //Choice to load CSV file
                {
                    if(beenThere == true)                 //Validates whether or not it has been loaded
                    {
                        wineItemCollection.ProcessCSV();                     //Sends to record array so it can be added on to the array
                    }
                    else
                    {
                        ui.AlreadyDidThat();                               //Tells user that the file has already been loaded
                    }
                    beenThere = false;                                       //Tells program file has already been loaded
                }
                if (choice == 2)                                          //Prints the entire list
                {                   
                        string bigListString = wineItemCollection.PrintEntireList();                       //Gathers all data from the array class
                        ui.PrintAllOutput(bigListString);                                                   //Prints data into the console
                }
                if (choice == 3)                                                              //Search for an item by its ID number
                {
                    string searchIDNumber = ui.SearchForRecord();                             //Gets the ID number from the user
                    string SearchedWineItem = wineItemCollection.SearchForWineItem(searchIDNumber);        //Gets record(or lack thereof) from the array class
                    if(SearchedWineItem == null)                      //Validates whether the record was found or not
                    {
                        ui.WrongSearch(searchIDNumber);              //Output of incorrect ID number
                    }
                    else
                    {
                        ui.SuccessfulSearch(SearchedWineItem);          //Output of correct record
                    }
                }
                if (choice == 4)                                       //Adds a record to the array input by the user
                {
                    WineItem AddedWineItem = ui.InputRecord();           //Gets the record input from the user
                    wineItemCollection.AddRecord(AddedWineItem);         //Adds Record to the array
                }
                choice = ui.Interact();                                    //Resets loop for options until the user inputs the exit command
            }

            Console.WriteLine("Thank You For Using Our Program");             //Nice message to the user, may comment out later
            Console.ReadLine();                                               //Ends the program
        }
    }
}
