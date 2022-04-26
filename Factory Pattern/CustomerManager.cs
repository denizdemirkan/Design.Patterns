using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class CustomerManager
    {
        ILoggerFactory loggerFactory;

        public CustomerManager(ILoggerFactory loggerFactory)
        {
            this.loggerFactory = loggerFactory;
        }

        public void Save()
        {
            Console.WriteLine("Customer saved.");
            ILogger logger = loggerFactory.CreateLogger();
            logger.Log();
        }
    }
}
