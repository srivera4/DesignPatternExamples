using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Interface
{
    public abstract class BookReader
    {
        public Book Book { get; set; }


        public BookReader()
        {
            Book = BuyBook();
        }


        public void DisplayOwnedBooks()
        {
            Console.WriteLine(Book.GetType().ToString());
        }

        public abstract Book BuyBook();

    }
}
