using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class AdventureBookReader : BookReader
    {
        public override Book BuyBook()
        {
            return new TreasureIsland();
        }

        public Book BuyBook<T>()
             where T : Book, new()
        {
            return new T();
        }
    }
}
