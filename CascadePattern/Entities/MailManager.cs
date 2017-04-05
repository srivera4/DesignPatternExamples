using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CascadePattern.Entities
{
    public class MailManager
    {
        public MailManager To(string emailAddress)
        {
            Console.WriteLine(emailAddress); 
            return this;
        }

        public MailManager From(string emailAddress)
        {
            Console.WriteLine(emailAddress);
            return this;
        }

        public MailManager Subject(string subject)
        {
            Console.WriteLine(subject);
            return this;
        }

        public MailManager Body(string body)
        {
            Console.WriteLine(body);
            return this;
        }

        public static void Send(Action<MailManager> action)
        {
            action(new MailManager());
            Console.WriteLine("Sent!");
        }
    }
}
