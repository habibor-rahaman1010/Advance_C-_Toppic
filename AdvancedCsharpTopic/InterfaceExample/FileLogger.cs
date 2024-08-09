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

        public void LogError(string message)
        {
            Log("ERROR", message);
        }

        public void LogInfo(string message)
        {
            Log("INFO", message);
        }

        private void Log(string messageType, string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
