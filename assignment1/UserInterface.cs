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
            this.PrintOptions();
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
            return Int32.Parse(input);
        }

        public void PrintAllOutput(string allOutput)
        {
            Console.WriteLine(allOutput);
            Console.WriteLine("Enter a key to continue");
            Console.ReadKey();
        }

        private void PrintOptions()
        {
            Console.WriteLine("What would you like to do?" + Environment.NewLine +
                "1.  Load the Wine List File(WARNING: This Can Only Be Done Once!)" + Environment.NewLine +
                "2.  Print the List" + Environment.NewLine +
                "3.  Search and Display Item by Item ID" + Environment.NewLine +
                "4.  Add A new Item to the list" + Environment.NewLine +
                "5.  Exit the Program" + Environment.NewLine);
        }
    }
}
