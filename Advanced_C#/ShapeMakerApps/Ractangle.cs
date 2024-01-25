using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMakerApps
{
    public class Ractangle : IShape
    {
        public string? Name { get; set; }  
        public double Width { get; set; }
        public double Height { get; set; }

        public Ractangle(string name, double width, double hight) 
        {
            this.Name = name;
            this.Width = width;
            this.Height = hight;
        }

        public void CopyingShape()
        {
            Console.WriteLine($"Cappying {Name} Shape...");
        }

        public void DrawShape()
        {
            Console.WriteLine($"Darwing {Name} Shape...");
        }

        public void Area()
        {
            double area = (double) this.Width * this.Height;
            Console.WriteLine($"Area of {this.Name} is: {area.ToString("N2")}");
        }
    }
}
