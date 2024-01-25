using System;

namespace MethodOverriding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle() { Height = 5, Width = 10 },
                new Rectangle() { Height = 10, Width = 20 },
                new Triangle() { Height = 12, Width = 30 },
            };

            Canvas canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
