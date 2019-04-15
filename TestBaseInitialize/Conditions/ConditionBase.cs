using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBaseInitialize
{
    public abstract class ConditionBase
    {
        public abstract string ConfigName { get; }
        public abstract string Load();
       
    }
}
