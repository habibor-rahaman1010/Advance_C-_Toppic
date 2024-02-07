using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class SMSMessage : IMessage
    {
        public void SendMessage(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"Sending SMS To: {contact.Number}");
            }
            Console.WriteLine();
        }
    }
}
