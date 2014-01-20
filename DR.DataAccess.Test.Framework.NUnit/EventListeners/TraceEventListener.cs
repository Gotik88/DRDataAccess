using System.Diagnostics;
using NUnit.Framework.Interfaces;

namespace DR.DataAccess.Test.Framework.NUnit.EventListeners
{
    public class TracingEventListener : ITestListener
    {
        public void TestStarted(ITest test)
        {
            WriteTrace("TestStarted");
        }

        public void TestFinished(ITestResult result)
        {
            WriteTrace("TestFinished({0})", result);
        }

        public void TestOutput(TestOutput testOutput)
        {
            if (testOutput.Type != TestOutputType.Trace)
            {
                WriteTrace("TestOutput {0}: '{1}'", testOutput.Type, testOutput.Text);
            }
        }

        private static void WriteTrace(string message, params object[] args)
        {
            Trace.TraceInformation(message, args);
        }
    }
}
