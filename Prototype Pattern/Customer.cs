using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    public class Customer : Person
    {
        public string Address { get; set; }
        public House HouseHold { get; set; }
        
        public override Person Clone()
        {
            return (Person)MemberwiseClone();
        }
    }
}
