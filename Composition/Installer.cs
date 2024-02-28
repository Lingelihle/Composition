using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class program 
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());
            
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();

            installer.Install();
        }
    }


    // in conclusion we declared that common functionality which was about logging in a seperate class
    // then we re-used that in two other classes using composition
    // we have two ways to re-use code one is inheritance , the other is compostion
}
