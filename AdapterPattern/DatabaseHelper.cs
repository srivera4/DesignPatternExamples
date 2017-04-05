using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class DatabaseHelper
    {
        public void QueryForChanges()
        {
            Console.WriteLine("Database queried.");
        }
    }
}
