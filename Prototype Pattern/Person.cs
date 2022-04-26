﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_Pattern
{
    public abstract class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public abstract Person Clone();
    }
}
