using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Shape
    {
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy to clipboard...");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape...");
        }
    }
}
