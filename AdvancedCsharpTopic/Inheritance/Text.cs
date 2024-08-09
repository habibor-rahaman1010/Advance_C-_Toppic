using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; } = string.Empty;

        public void AddHyperLink(string url)
        {
            Console.WriteLine("We added hyper link {0}", url);
        }  
    }
}
