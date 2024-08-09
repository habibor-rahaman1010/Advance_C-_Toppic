namespace UpcastingDowncasting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Upcasting...
            Text text = new Text();
            Shape shape = text;
            Shape s = new Shape();
            
            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width);
            Console.WriteLine(shape.Width);

            //Dwoncasting...
            Shape shape1 = new Text();
            Text text1 = (Text) shape1;
        }
    }
}
