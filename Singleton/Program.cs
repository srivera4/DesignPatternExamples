using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton();
        }

        private static void Singleton()
        {
            var configurationManager = ConfigurationManager.GetInstance;
            configurationManager.DisplayConfiguration();

            var businessRulesManager = BusinessRulesManager.GetInstance;
            businessRulesManager.DisplayRules();

            Console.ReadKey();
        }
    }
}
