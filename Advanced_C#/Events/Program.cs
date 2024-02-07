using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
namespace Events
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello programmer");
            Box box = new Box();

            box.OpenedBox += OpenedTheBox;
            box.CloseedBox += ClosedTheBox;
            box.OpenedBox += OpenTest;
            box.Publiesd += Video;
            box.BoxDestroy += DestroyTheBox;

            void OpenedTheBox(DateTime time) => Console.WriteLine(time);
            void OpenTest(DateTime time) => Console.WriteLine(time.DayOfWeek);
            void ClosedTheBox(DateTime time) => Console.WriteLine(time);
            bool Video(DateTime time) => true;

            box.Open();
            box.Close();
            bool? result =  box.VideoUploaded();
            box.Destroy();

            Console.WriteLine(result == true ? "Video Published Successfully" : "Video Not Published");

            void DestroyTheBox(DateTime time) => Console.WriteLine($"Destroyed in {time}");
        }
    }
}