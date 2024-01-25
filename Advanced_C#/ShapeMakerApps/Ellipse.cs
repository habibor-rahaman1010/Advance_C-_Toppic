using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMakerApps
{
    internal class Ellipse : IShape
    {
        public string? Name { get; set; }
        public double Xaxis { get; set; }
        public double Yaxis { get; set; }

        public Ellipse(string? name, double xaxis, double yaxis)
        {
            this.Name = name;
            this.Xaxis = xaxis;
            this.Yaxis = yaxis;
        }

        public void Area()
        {
            double area = Math.Abs(Math.PI * this.Xaxis * this.Yaxis);
            Console.WriteLine($"Area of {this.Name} is: {area.ToString("N2")}");
        }

        public void CopyingShape()
        {
            Console.WriteLine($"Cappying {Name} Shape...");
        }

        public void DrawShape()
        {
            Console.WriteLine($"Darwing {Name} Shape...");
        }
    }
}
