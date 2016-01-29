using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private string idNumberString;                     //Strings inside of each item record
        private string itemNameString;
        private string quantityString;

       //Getters and setters
        
        public string IDNumberString                       
        {
            get { return idNumberString; }
            set { idNumberString = value; }
        }

        public string ItemNameString                 
        {
            get {return itemNameString ;}
            set { itemNameString = value; }
        }

        public string QuantityString
        {
            get { return quantityString; }
            set {quantityString = value;}
        }

       
        //Override of ToString method in order to make the data readable by the user
        public override string ToString()
        {
            return this.idNumberString + " " + this.itemNameString + " " + this.quantityString;
        }


        //Constructor
        public WineItem(string idNumberString, string itemNameString, string quantityString)
        {
            this.idNumberString = idNumberString;
            this.itemNameString = itemNameString;
            this.quantityString = quantityString;
        }

        //Empty Constructor
        public WineItem()
        {

        }
    }
}
