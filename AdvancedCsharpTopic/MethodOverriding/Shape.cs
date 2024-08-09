using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public Shape() 
        {
            this.Position = new Position();
        }

        public Shape(int width, int height, Position position) : this()
        {
            this.Width = width;
            this.Height = height;
            this.Position = position;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shap");
        }
    }
}
