using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class Delegate
    {
        public delegate void Perform(string text);

        public void PrintingMethod(string textToPrint)
        {
            Console.WriteLine($"--::{textToPrint}::--");
        }

        public void ProcessText(string text, Perform perform)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                perform.Invoke(text);
            }
        }
    }
}
