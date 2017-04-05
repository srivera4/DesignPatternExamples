using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FantasyBookReader : BookReader
    {
        public override Book BuyBook()
        {
            return new LordOfTheRings();
        }
    }
}
