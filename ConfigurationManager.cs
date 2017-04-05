using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private static object syncRoot = new object();

        public ConfigurationManager()
        {
              
        }

        public static ConfigurationManager GetInstance
        {
            get
            {
                lock(syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new ConfigurationManager();
                    }
                }

                return instance;
            }
        }

        public void DisplayConfiguration()
        {
            Console.WriteLine("Single instance object");
        }
    }
}
