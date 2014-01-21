using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;

namespace DR.DataAccess.Test
{
    public class BasePerformanceTest : BaseTest
    {
        private Stopwatch _testWatcher;
        private readonly Dictionary<string, TimeSpan> _testNameExecutionTimeDic;

        public Dictionary<string, TimeSpan> TimeDictionary
        {
            get
            {
                return _testNameExecutionTimeDic;
            }
        }

        public BasePerformanceTest()
        {
            _testNameExecutionTimeDic = new Dictionary<string, TimeSpan>();
        }

        [SetUp]
        public void BaseSetUp()
        {
            _testWatcher = new Stopwatch();
            _testWatcher.Start();
        }

        [TearDown]
        public void BaseTearDown()
        {
            _testWatcher.Stop();
            _testNameExecutionTimeDic.Add(Guid.NewGuid().ToString(), _testWatcher.Elapsed);
            _testWatcher.Reset();
        }
    }
}
