using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class DbMigrator
    {
        public readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }
        
        public void Migrate()
        {
            _logger.LogInfo("Migration start at {0}" + DateTime.Now.ToString());

            Thread.Sleep(2000);

            _logger.LogInfo("Migration eand at {0}" + DateTime.Now.ToString());
        }
    }
}
