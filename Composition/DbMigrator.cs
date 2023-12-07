using System.Security.Cryptography.X509Certificates;

namespace Componsition
{
    class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
            {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("MIGRATING ...");
        }
        
    }
}