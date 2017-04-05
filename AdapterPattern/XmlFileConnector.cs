using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class XmlFileConnector : Connector
    {
        public override void GetData()
        {
            var xmlfileLoader = new XmlFileLoader();
            xmlfileLoader.LoadXML();
        }
    }
}
