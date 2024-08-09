using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndPolymorphism
{
    internal class Sms : INotificationChannel
    {
        public bool Send(Message message)
        {
            Console.WriteLine("SMS Notification send...");
            return true;
        }
    }
}
