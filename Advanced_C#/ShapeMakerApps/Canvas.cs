using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMakerApps
{
    public class Canvas
    {
        private readonly List<IShape> _shapes;

        public Canvas(List<IShape> shapes)
        {   
            this._shapes = shapes;
        }
       
        public void DrawingShaps()
        {
            foreach (IShape shape in _shapes)
            {
                shape.DrawShape();
                shape.CopyingShape();
                shape.Area();
                Console.WriteLine();
            }
        }
    }
}
