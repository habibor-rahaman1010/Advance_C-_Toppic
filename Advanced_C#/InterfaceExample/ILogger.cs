using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface ILogger
    {
        void LogInfo(string massage);
        void LogWarning(string massage);
        void LogError(string massage);
    }
}
