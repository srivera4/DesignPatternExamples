using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter();
        }

        public static void Adapter()
        {
            var tradingdataImporter = new TradingDataImporter();

            Connector databaseConnector = new DatabaseConnector();
            tradingdataImporter.ImportData(databaseConnector);

            Connector xmlfileConnector = new XmlFileConnector();
            tradingdataImporter.ImportData(xmlfileConnector);

            Connector httpstreamConnector = new HttpStreamConnector();
            tradingdataImporter.ImportData(httpstreamConnector);

            Console.ReadKey();
        }
    }
}
