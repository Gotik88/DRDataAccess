using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Extensibility;

namespace DR.DataAccess.Test.Framework.NUnit
{
    internal class SuiteCustomBuilder:ISuiteBuilder
    {
        public bool CanBuildFrom(Type type)
        {
            return Reflect.HasAttribute(type, "NUnitAddinAttributes.SuiteBuilderAttribute", false);
        }

        public Test BuildFrom(Type type)
        {
            return new SuiteTestBuilder(type);
        }
    }
}
