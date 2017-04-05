using Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Milk : ProductPrototype
    {
        public Milk(decimal price)
            :base(price)
        {

        }

        //implement Iclonable if deep clone is required...if we have a member reference
        public override ProductPrototype Clone()
        {
            return (ProductPrototype)this.MemberwiseClone();

            // Deep Copy: all objects are duplicated when implementing Iclonable
            //return (ProductPrototype)this.Clone();
        }
    }
}
