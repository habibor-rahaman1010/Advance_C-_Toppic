using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Box
    {
        //This is my delegates
        public delegate void OpenBoxDelegates(DateTime x);
        public delegate void CloseBoxDelegates(DateTime x);
        public delegate bool VideoPublished(DateTime x);

        // here this is my all events
        public event OpenBoxDelegates? OpenedBox;
        public event CloseBoxDelegates? CloseedBox;
        public event VideoPublished? Publiesd;
        public event Action<DateTime>? BoxDestroy;

        public void Open()
        {
            OpenedBox?.Invoke(DateTime.Now);
        }

        public void Close()
        {
            CloseedBox?.Invoke(DateTime.Now);
        }

        public bool? VideoUploaded()
        {
            Console.WriteLine("Video Uploading....");
            Thread.Sleep(3000);
            return Publiesd?.Invoke(DateTime.Now);
        }

        public void Destroy()
        {
            BoxDestroy?.Invoke(DateTime.Now);
        }
    }
}
