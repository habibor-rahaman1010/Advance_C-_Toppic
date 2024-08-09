﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Rectangle : Shape
    {
        public Rectangle(string shapeName)
        {
            this.ShapeName = shapeName;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing the {0}", this.ShapeName);
        }
    }
}
