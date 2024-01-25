using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo($"Migration Started at {DateTime.Now}");
            Thread.Sleep( 3000 );

            //Details of migrating the database

            _logger.LogInfo($"Migrating finished at {DateTime.Now}");
            _logger.LogWarning($"Your migration was consummin some more time, please write code properly...");
            _logger.LogError("Some Error occured...");
        }
    }
}
