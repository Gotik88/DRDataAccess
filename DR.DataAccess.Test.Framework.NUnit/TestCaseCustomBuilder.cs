using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;
using NUnit.Framework.Extensibility;
using NUnit.Framework.Interfaces;
using NUnit = NUnit.Framework.Internal;

namespace DR.DataAccess.Test.Framework.NUnit
{
    internal class TestCaseCustomBuilder
    {
        /* public bool CanBuildFrom(MethodInfo method)
         {
             return method.IsDefined(typeof(TestAttribute), false)
                  || method.IsDefined(typeof(ITestCaseSource), false)
                  || method.IsDefined(typeof(TheoryAttribute), false);
         }



         public Test BuildFrom(MethodInfo method)
         {
             return null;
             return testCaseProvider.HasTestCasesFor(method)
                  ? BuildParameterizedMethodSuite(method, parentSuite)
                  : BuildSingleTestMethod(method, parentSuite, null);
         }*/
    }
}
