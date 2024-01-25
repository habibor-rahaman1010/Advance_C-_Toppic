using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Shape
    {
        public int Width { get; set; } = 0;
        public int Height { get; set; } = 0;

        public virtual void Draw()
        {

        }
    }
}
