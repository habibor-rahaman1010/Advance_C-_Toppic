using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class ConsolLogger : ILogger
    {
        public void LogInfo(string massage)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(massage);
        }
        public void LogWarning(string massage)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(massage);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void LogError(string massage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(massage);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
