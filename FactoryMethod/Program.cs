using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod();
        }

        private static void FactoryMethod()
        {
            var bookReaderList = new List<BookReader>();

            bookReaderList.Add(new AdventureBookReader());
            bookReaderList.Add(new FantasyBookReader());
            bookReaderList.Add(new HorrorBookReader());

            foreach (var reader in bookReaderList)
            {
                Console.WriteLine(reader.GetType().ToString());
                // language agnostic solution
                reader.DisplayOwnedBooks();

                Console.WriteLine();
            }

            // C# specific solution using generics
            var genericReader = new GenericBookReader();
            Book book = genericReader.BuyBook<Encyclopedia>();            
            Console.WriteLine(book.GetType().ToString());

            Console.ReadKey();
        }
    }
}
