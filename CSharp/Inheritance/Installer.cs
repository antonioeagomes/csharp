namespace CSharp.Inheritance
{
    public class Installer
    {
        /* 
            Association - Composition 
            Relationship Has-A: Installer has a Logger
        */
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("Installing...");
        }
    }
}