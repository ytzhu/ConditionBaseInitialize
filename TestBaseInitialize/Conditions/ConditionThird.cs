using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBaseInitialize
{
    public class ConditionThird : ConditionBase
    {
        public override string ConfigName => "ConditionThird";

        public override string Load()
        {
            return "Third";
        }
    }
}
