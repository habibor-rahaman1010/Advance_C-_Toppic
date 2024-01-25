using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMakerApps
{
    internal class Circle : IShape
    {
        public string? Name { get; set; }
        public double Radious { get; set; }

        public Circle(string name, double radious) 
        { 
            this.Name = name;
            this.Radious = radious;
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
            double area = (double) Math.PI * this.Radious * this.Radious;
            Console.WriteLine($"Area of {this.Name} is: {area.ToString("N2")}");
        }
    }
}
