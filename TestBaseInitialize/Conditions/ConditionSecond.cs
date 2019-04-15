using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBaseInitialize
{
    public class ConditionSecond : ConditionBase
    {
        public override string ConfigName => "ConditionSecond";

        public override string Load()
        {
            return "Second";
        }
    }
}
