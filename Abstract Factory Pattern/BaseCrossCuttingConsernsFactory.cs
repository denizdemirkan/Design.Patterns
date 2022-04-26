using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public abstract class BaseCrossCuttingConsernsFactory
    {
        public abstract BaseLogger CreateLogger();
        public abstract BaseCache CreateCache();
    }
}
