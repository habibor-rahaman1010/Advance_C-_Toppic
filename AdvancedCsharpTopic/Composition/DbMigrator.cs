﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            this._logger.Log("The database was migrated!");
        }
    }
}
