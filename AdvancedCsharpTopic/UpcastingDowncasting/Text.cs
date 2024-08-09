using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting
{
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string  FontName { get; set; } = string.Empty;

        public void CopiedText()
        {
            Console.WriteLine("Copied text from clipboard!");
        }
    }
}
