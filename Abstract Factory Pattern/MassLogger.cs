using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class MassLogger : BaseLogger
    {
        public override void Log(string message)
        {
            Console.WriteLine("MassLogger: " + message);
        }
    }
}
