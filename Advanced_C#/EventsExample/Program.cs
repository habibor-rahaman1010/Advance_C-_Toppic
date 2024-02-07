using System;

namespace EventsExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact { Email = "habibor.rahaman1010@gmail.com", Number = "01768280237" });
            contacts.Add(new Contact { Email = "Abdullah245@gmail.com", Number = "01737823731" });
            contacts.Add(new Contact { Email = "abdurrahman2929@gmail.com", Number = "0176278372"});

            Notifier notifier = new Notifier();
            notifier.Notification += new Notifier.SendMessage(new EmailMessage().SendMessage);
            notifier.Notification += new Notifier.SendMessage(new SMSMessage().SendMessage);
            notifier.Notification += new Notifier.SendMessage(new SendLetter().SendMessage);
            notifier.Notification += new Notifier.SendMessage(MMSMessage.SendMessage);

            notifier.Notify(contacts);
        }
    }
}
