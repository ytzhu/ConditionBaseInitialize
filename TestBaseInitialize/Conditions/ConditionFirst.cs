using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBaseInitialize
{
    public class ConditionFirst : ConditionBase
    {
        public override string ConfigName => "ConditionFirst";

        public override string Load()
        {
            return "First";
        }
    }
}
