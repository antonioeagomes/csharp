using System;

namespace CSharp.Interfaces
{
    public class DBMigrator
    {
        /* Dependency Injection */
        private readonly ILogger _logger;
        public DBMigrator(ILogger logger)
        {
            _logger = logger;

        }

        public void Migrate()
        {
            // Console.WriteLine("Migration started at {0}", DateTime.Now); // Without DI
            _logger.LogInfo($"Migration started at {DateTime.Now}"); // With Dependency Injection

            _logger.LogInfo($"Migration finished at {DateTime.Now}"); // With Dependency Injection
            // Console.WriteLine("Migration finished at {1}", DateTime.Now);
        }
    }
}