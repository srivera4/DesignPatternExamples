using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CascadePattern.Entities;

namespace CascadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MailManager.Send((mail) => mail
                        .From("djgxpr@aol.com")
                        .To("SamuelRiveraPrado@gmail.com")
                        .Subject("Code Sample")
                        .Body("This is an email body"));
               
        }
    }
}
