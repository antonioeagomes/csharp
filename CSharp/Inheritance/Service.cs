using System;

namespace CSharp.Inheritance
{
    public class Service
    {
        /* 
            Association - Composition 
            Relationship Has-A: Service has a Logger
        */
        private readonly Logger _logger;

        public Service(Logger logger)
        {
            _logger = logger;
        }

        public void Start()
        {
            _logger.Log($"Started at: {DateTime.Now}");
        }
    }
}