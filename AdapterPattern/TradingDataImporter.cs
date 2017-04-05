using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class TradingDataImporter
    {
        public void ImportData(Connector connector)
        {
            connector.GetData();
        }
    }
}
