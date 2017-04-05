using AdapterPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class DatabaseConnector : Connector
    {
        public override void GetData()
        {
            var databaseHelper = new DatabaseHelper();
            databaseHelper.QueryForChanges();
        }
    }
}
