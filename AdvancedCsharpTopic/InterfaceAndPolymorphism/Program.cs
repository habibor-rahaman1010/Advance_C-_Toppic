namespace InterfaceAndPolymorphism
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VideoEncoder encoder = new VideoEncoder();

            encoder.RegisterNotificationChannel(new MailService());
            encoder.RegisterNotificationChannel(new Sms());
            encoder.Encode(new Video());
        }
    }
}
