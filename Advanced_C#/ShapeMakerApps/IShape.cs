using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMakerApps
{
    public interface IShape
    {
        public string? Name { get; set; }
        public void DrawShape();
        public void CopyingShape();
        public void Area();
    }
}
