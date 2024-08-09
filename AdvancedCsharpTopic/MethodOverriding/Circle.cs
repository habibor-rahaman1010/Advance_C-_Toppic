﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Circle : Shape
    {
        public string ObjectName { get; set; } = string.Empty;

        public Circle(string objectName, int width, int height, Position position) :base(width, height, position)
        {   
            this.ObjectName = objectName;  
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing the {0}", this.ObjectName);
        }
    }
}