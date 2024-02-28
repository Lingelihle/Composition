using System;
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

            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("we are migrating");
        }
    }
}

// connect from logger file or class created, then from there we head to installer 