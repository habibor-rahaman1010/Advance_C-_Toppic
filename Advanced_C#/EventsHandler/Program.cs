using System;

namespace EventsHandler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Video video = new Video() 
            { 
                Title = "Events And Delegates", 
                Description = "This Is C# Topics",
                VideoLength = "35 Minuites",
                VideoSize = "48 MB"
            };

            VideoEncoder encoder = new VideoEncoder(); //Publisher

            MailService mail = new MailService(); //Subscriber
            MobileSMSService SMS = new MobileSMSService(); //Subscriber

            encoder.VideoEncoded += mail.OnVideoEncoded;
            encoder.VideoEncoded += SMS.OnVideoEncoded;
            
            encoder.Encode(video);
        }
    }
}
