using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndPolymorphism
{
    public interface INotificationChannel
    {
        bool Send(Message message);
    }
}
