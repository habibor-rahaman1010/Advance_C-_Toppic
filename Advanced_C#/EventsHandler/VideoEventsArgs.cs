using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandler
{
    public class VideoEventsArgs : EventArgs
    {
        public Video? MyVideo { get; set; }
    }
}
