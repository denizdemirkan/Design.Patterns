using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class ProductManager
    {
        private BaseCrossCuttingConsernsFactory cccFactory;

        private BaseLogger logger;
        private BaseCache cache;

        public ProductManager(BaseCrossCuttingConsernsFactory cccFactory)
        {
            this.cccFactory = cccFactory;
            this.logger = cccFactory.CreateLogger();
            this.cache = cccFactory.CreateCache();
        }

        public void CRUD() 
        {
            logger.Log("Product Logged.");
            cache.Cache("Product Cached");
            Console.WriteLine("CRUD's done!");
        }
    }
}
