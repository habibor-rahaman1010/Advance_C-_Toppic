using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public string ShapeName { get; set; } = string.Empty;

        public abstract void Draw(); 

        public void Copied()
        {
            Console.WriteLine("Copy shape into clipboard");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape ");
        }
    }
}
