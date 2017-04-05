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
            var clientRepository = new ClientRepository();
            var productRepository = new ProductRepository();

            var clientDataObject = new ClientDataObject();
            clientRepository.AddObject(clientDataObject);
            clientRepository.SaveChanges();

            clientRepository.CopyObject(clientDataObject);

            clientRepository.RemoveObject(clientDataObject);
            clientRepository.SaveChanges();

            var productDataObject = new ProductDataObject();
            productRepository.AddObject(productDataObject);
            clientRepository.SaveChanges();

            productRepository.CopyObject(productDataObject);

            productRepository.RemoveObject(productDataObject);
            productRepository.SaveChanges();

            Console.ReadKey();
        }
    }
}
