using System;

namespace ShapeMakerApps
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Ractangle ractangle = new Ractangle("Ractangle", 20.5, 5.8);
            Circle circle = new Circle("Circle", 16.6);
            Ellipse ellipse = new Ellipse("Ellipse", 12, 2);

            List<IShape> shapes = new List<IShape>();
            shapes.Add(ractangle);
            shapes.Add(circle);
            shapes.Add(ellipse);


            Canvas canvas = new Canvas(shapes);
            canvas.DrawingShaps();
        }
    }
}
