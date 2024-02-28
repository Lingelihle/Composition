using System;

namespace Composition
{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Install()
        {
            _logger.Log("We are installing the application");
        }
    }
}

// from here we create a new page class for Installler 