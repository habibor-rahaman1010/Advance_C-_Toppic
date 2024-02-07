using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public static class MMSMessage
    {
        public static void SendMessage(List<Contact> contacs)
        {
            foreach (Contact contact in contacs)
            {
                Console.WriteLine($"Sending MMS To: {contact.Number}");
            }
            Console.WriteLine();
        }
    }
}
