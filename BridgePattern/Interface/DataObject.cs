using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Interface
{
    public abstract class DataObject
    {
        public abstract void Register();
        public abstract DataObject Copy();
        public abstract void Delete();
    }
}
