using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsHandler
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedEventHandler(object source, VideoEventsArgs args);

        public event VideoEncodedEventHandler? VideoEncoded;

        /*public event EventHandler<VideoEventsArgs>? VideoEncoded;*/ 
        public void Encode(Video video)
        {
            Console.WriteLine("Video Encoding Now...");
            Thread.Sleep(3000);
            Console.WriteLine($"The Video Encoding Size: {video.VideoSize}");
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            VideoEncoded?.Invoke(this, new VideoEventsArgs() { MyVideo = video});
        }
    }
}
