using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    public class Notifier
    {
        public delegate void SendMessage(List<Contact> contacts);
        public event SendMessage? Notification;

        public void Notify(List<Contact> contacts)
        {
            Notification?.Invoke(contacts);
        }
    }
}
