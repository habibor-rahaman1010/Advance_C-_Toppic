using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class SendLetter : IMessage
    {
        public void SendMessage(List<Contact> contacts)
        {
            foreach (Contact contact in contacts)
            {
                Console.WriteLine($"Send Letter To: {contact.Email}");
            }
            Console.WriteLine();
        }
    }
}
