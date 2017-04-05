using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory();
        }

        public static void AbstractFactory()
        {
            // Language agnostic version
            CarFactory audiFactory = new AudiFactory();
            Driver driver1 = new Driver(audiFactory);
            driver1.CompareSpeed(); ;

            CarFactory mercedesFactory = new MercedesFactory();
            Driver driver2 = new Driver(mercedesFactory);
            driver2.CompareSpeed();

            // C# specific version using generics
            var factory = new GenericFactory<MercedesSportsCar>();
            var mercedesSportsCar = factory.CreateObject();
            Console.WriteLine(mercedesSportsCar.GetType().ToString());

            Console.ReadKey();
        }
    }
}
