using System;

namespace AbstractClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle() { Width = 5, Height = 20},
                new Rectangle() { Width = 5, Height = 30},
                new Pentagon() { Width = 6, Height = 1},
            }; 

            Canvas canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
