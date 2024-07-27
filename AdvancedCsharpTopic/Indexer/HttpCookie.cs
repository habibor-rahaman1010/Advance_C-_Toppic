using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _cookies;

        public HttpCookie()
        {
            this._cookies = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return this._cookies[key]; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value");
                }
                else
                {
                    this._cookies[key] = value;
                }
            }
        }
    }
}
