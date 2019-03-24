using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bridge();
        }

        public static void Bridge()
        {
            // Create RefinedAbstraction this is what makes it different from strategy pattern structural vs behavioral 

            Customers customers = new Customers("Chicago");

            // Set ConcreteImplementor

            customers.Data = new CustomersData();

            // Exercise the bridge

            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            // Wait for user

            Console.ReadKey();
        }
    }
}
