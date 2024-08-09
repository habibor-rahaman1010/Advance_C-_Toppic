namespace Inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Text text = new Text();
            text.FontName = "Cascadia Mono";
            text.FontSize = 12;

            text.AddHyperLink("https//:www.google.com");
            text.Copy();
        }
    }
}
