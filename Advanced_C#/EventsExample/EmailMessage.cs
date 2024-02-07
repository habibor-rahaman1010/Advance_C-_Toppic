using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class EmailMessage : IMessage
    {
        public void SendMessage(List<Contact> contacs)
        {
            foreach (Contact contact in contacs)
            {
                Console.WriteLine($"Sending Email To: {contact.Email}");
            }
            Console.WriteLine();
        }
    }
}
