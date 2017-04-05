using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class HttpStreamConnector : Connector
    {
        public override void GetData()
        {
            var websiteScanner = new WebSiteScanner();
            websiteScanner.Scan();
        }
    }
}
