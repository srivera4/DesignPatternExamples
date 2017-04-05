using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Interface;

namespace FactoryMethod
{
    public class GenericBookReader : Genric
    {
        public override Book BuyBook<T>()
        {
            return new T();
        }
    }
}
