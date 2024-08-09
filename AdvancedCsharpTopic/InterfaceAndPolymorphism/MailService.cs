using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndPolymorphism
{
    public class MailService : INotificationChannel
    {
        public bool Send(Message message)
        {
            Console.WriteLine("Mail notification send...");
            return true;
        }
    }
}
