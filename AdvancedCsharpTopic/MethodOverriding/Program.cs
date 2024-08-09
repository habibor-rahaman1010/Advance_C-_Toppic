namespace MethodOverriding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            shapes.Add(new Circle("Circle", 5, 4, new Position()));
            shapes.Add(new Rectangle("Rectangle", 4, 11, new Position()));

            Canvas canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
