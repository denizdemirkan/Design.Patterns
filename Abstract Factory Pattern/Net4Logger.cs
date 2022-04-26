using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class Net4Logger : BaseLogger
    {
        public override void Log(string message)
        {
            Console.WriteLine("Net4Logger: " + message);
        }
    }
}
