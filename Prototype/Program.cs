using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype();
        }

        private static void Prototype()
        {
            // Language agnostic solution
            var supermarket = new SuperMarket();

            supermarket.AddProduct("Milk", new Milk(0.89m));
            supermarket.AddProduct("Bread", new Bread(1.10m));

            decimal sourcePrice;
            decimal currentPrice;

            var clonedMilk = (Milk)supermarket.GetProduct("Milk");
            clonedMilk.Price = 1;
            sourcePrice = supermarket.GetProduct("Milk").Price;
            currentPrice = clonedMilk.Price;
            Console.WriteLine(String.Format("{0} | {1}", sourcePrice, currentPrice));

            var clonedBread = (Bread)supermarket.GetProduct("Bread");
            clonedBread.Price = 2;
            sourcePrice = supermarket.GetProduct("Bread").Price;
            currentPrice = clonedBread.Price;
            Console.WriteLine(String.Format("{0} | {1}", sourcePrice, currentPrice));

            // C# specific solution using the ICloneable interface
            var cloneableProduct = new CloneableProduct(100);
            var clonedProduct = (CloneableProduct)cloneableProduct.Clone();
            clonedProduct.Price = 200;
            sourcePrice = cloneableProduct.Price;
            currentPrice = clonedProduct.Price;
            Console.WriteLine(String.Format("{0} | {1}", sourcePrice, currentPrice));

            Console.ReadKey();
        }
    }
}
