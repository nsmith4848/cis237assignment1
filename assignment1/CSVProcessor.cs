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
        public void ProcessCSV(string pathToCSV, WineItemCollection wineItemList)
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader();

                int counter = 0;

                while(line = streamReader.ReadLine(pathToCSV) != null)
                {
                    processLine(line, )
                }
            }
            catch
            {

            }
        }

        ReadLine()
    }
}
