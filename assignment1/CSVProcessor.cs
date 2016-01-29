using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        public bool ProcessCSV(string pathToCSV, WineItem[] wineItemList)
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader(pathToCSV);

                int counter = 0;

                while((line = streamReader.ReadLine()) != null)
                {
                    ProcessRecord(line, wineItemList, counter++);
                }

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine(ex.StackTrace);
                return false;
            }

            finally
            {

                if(streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }

       private void ProcessRecord(string line,WineItem[] wineItemList, int index)
        {
            string[] parts = line.Split(',');

            string idNumberString = parts[0];
            string itemNameString = parts[1];
            string quantityString = parts[2];



           wineItemList[index] = new WineItem(idNumberString, itemNameString, quantityString);
        }
    }
}
