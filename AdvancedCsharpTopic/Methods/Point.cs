using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Point
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if(newLocation == null)
            {
                throw new ArgumentNullException("newLocation");
            }
            Move(newLocation.X, newLocation.Y);
        } 
    }
}
