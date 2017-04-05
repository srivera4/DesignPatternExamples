using FactoryMethod.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Genric
    {
        public Book Book { get; set; }

        public void DisplayOwnedBooks()
        {
            Console.WriteLine(Book.GetType().ToString());
        }

        public abstract Book BuyBook<T>() where T : Book, new();

    }
}
