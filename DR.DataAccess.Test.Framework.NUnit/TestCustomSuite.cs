using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;

using global::NUnit.Framework.Interfaces;

namespace DR.DataAccess.Test.Framework.NUnit
{
    public class TestCustomSuite : TestSuite
    {
        public TestCustomSuite(Type type)
            : base(type)
        {
            this.Name = type.Namespace ?? "[default namespace]";
            int index = this.Name.LastIndexOf('.');
            if (index > 0)
            {
                this.Name = this.Name.Substring(index + 1);
            }

            this.oneTimeSetUpMethods = GetSetUpTearDownMethods(typeof(SetUpAttribute));
            this.oneTimeTearDownMethods = GetSetUpTearDownMethods(typeof(TearDownAttribute));
        }

        private MethodInfo[] GetSetUpTearDownMethods(Type attrType)
        {
            MethodInfo[] methods = Reflect.GetMethodsWithAttribute(FixtureType, attrType, true);

            foreach (MethodInfo method in methods)
                if (method.IsAbstract ||
                    !method.IsPublic && !method.IsFamily ||
                    method.GetParameters().Length > 0 ||
                    !method.ReturnType.Equals(typeof(void)))
                {
                    this.Properties.Set(PropertyNames.SkipReason, string.Format("Invalid signature for SetUp or TearDown method: {0}", method.Name));
                    this.RunState = RunState.NotRunnable;
                    break;
                }

            return methods;
        }
    }
}
