using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    public class DnzLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged with DnzLogger");
        }
    }
}
