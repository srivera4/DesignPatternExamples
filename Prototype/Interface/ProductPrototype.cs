using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Interface
{
    public abstract class ProductPrototype
    {
        public decimal Price { get; set; }

        public ProductPrototype(decimal price)
        {
            Price = price;
        }

        public abstract ProductPrototype Clone();
    }
}
