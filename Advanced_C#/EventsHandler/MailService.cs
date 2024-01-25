using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandler
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventsArgs args)
        {
            Console.WriteLine($"Send Email: New Video Published Cheack It Out. {args?.MyVideo?.Title}.");
        }
    }
}
