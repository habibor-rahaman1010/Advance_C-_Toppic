namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape>shapes = new List<Shape>();
            shapes.Add(new Circle("Circle"));
            shapes.Add(new Rectangle("Rectangle"));

            Canvas canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
