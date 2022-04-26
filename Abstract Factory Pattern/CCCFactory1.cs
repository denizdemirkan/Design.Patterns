using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class CCCFactory1 : BaseCrossCuttingConsernsFactory
    {
        public override BaseCache CreateCache()
        {
            return new RedisCache();
        }

        public override BaseLogger CreateLogger()
        {
            return new Net4Logger();
        }
    }
}
