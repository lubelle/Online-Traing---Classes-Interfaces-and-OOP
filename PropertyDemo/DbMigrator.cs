using System;

namespace PropertyDemo
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)   // the extension point
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            // details of migrating the database
            _logger.LogInfo("Migration finished at " + DateTime.Now);
        }
    }
}
