using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;  
        }
        public void LogInfo(string massage)
        {
            Log(massage, "Info");
        }

        public void LogWarning(string massage)
        {
            Log(massage, "Warnin");
        }

        public void LogError(string massage)
        {
            Log(massage, "Error");
        }

        private void Log(string massage, string massageType)
        {
            using (StreamWriter streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{massageType}: {massage}");
            }
        }
    }
}
