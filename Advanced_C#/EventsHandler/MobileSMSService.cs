using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandler
{
    public class MobileSMSService
    {
        public void OnVideoEncoded(object source, VideoEventsArgs args)
        {
            Console.WriteLine($"Mobile SMS: New Video Launce You Can See. {args?.MyVideo?.Title}.");
        }
    }
}
