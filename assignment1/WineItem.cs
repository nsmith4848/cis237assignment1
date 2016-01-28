using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private Int32 idNumberInt32;
        private string itemNameString;
        private string quantityString;

        public Int32 IDNumberInt32
        {
            get { return idNumberInt32; }
            set { idNumberInt32 = value; }
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

        public override string ToString()
        {
            return this.idNumberInt32.ToString() + " " + this.itemNameString + " " + this.quantityString;
        }

        public WineItem(Int32 idNumberInt32, string itemNameString, string quantityString)
        {
            this.idNumberInt32 = idNumberInt32;
            this.itemNameString = itemNameString;
            this.quantityString = quantityString;
        }

        public WineItem()
        {

        }
    }
}
