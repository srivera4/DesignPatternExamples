using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethodPattern.Interface;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessObject daoCategories = new Categories();
            daoCategories.Run();

            DataAccessObject daoProducts = new Products();
            daoProducts.Run();

            // Wait for user
            Console.ReadKey();
        }
    }
}
