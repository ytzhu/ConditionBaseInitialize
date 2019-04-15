using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace TestBaseInitialize
{
    public class ConditionInitiate
    {
        public static Dictionary<string, ConditionBase> conditions;
        public ConditionInitiate()
        {
            Initalize();
        }
        public static void Initalize()
        {
            if (conditions == null)
            {
                conditions = new Dictionary<string, ConditionBase>();
                var baseType = typeof(ConditionBase);
                var assembly = Assembly.GetAssembly(baseType);

                var classes = assembly.GetTypes()
                    .Where(o => !o.IsAbstract && baseType.IsAssignableFrom(o));

                foreach (var item in classes)
                {
                    var instance = Activator.CreateInstance(item);
                    var properities = instance.GetType();
                    var property = properities.GetProperty("ConfigName");
                    string name = property.GetValue(instance, null)?.ToString();

                    conditions.Add(name, (ConditionBase)instance);

                }
            }
        }
    }
}
