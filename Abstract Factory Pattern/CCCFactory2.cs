using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class CCCFactory2 : BaseCrossCuttingConsernsFactory
    {
        public override BaseCache CreateCache()
        {
            return new MemCache();
        }

        public override BaseLogger CreateLogger()
        {
            return new MassLogger();
        }
    }
}
