using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public interface IMessage
    {
        public void SendMessage(List<Contact> contacs);
    }
}
