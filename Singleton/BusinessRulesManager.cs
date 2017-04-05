using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class BusinessRulesManager
    {
        private BusinessRulesManager()
        {

        }

        public static BusinessRulesManager GetInstance
        {
            get
            {
                return BusinessRulesManagerImpl.instance;
            }
        }

        public void DisplayRules()
        {
            Console.WriteLine("Single instance object");
        }

        private class BusinessRulesManagerImpl
        {
            static BusinessRulesManagerImpl()
            {

            }

            internal static readonly BusinessRulesManager instance = new BusinessRulesManager();
        }
    }
}
