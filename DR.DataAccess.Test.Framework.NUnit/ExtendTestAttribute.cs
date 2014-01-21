using System;
using System.IO;
using DR.DataAccess.Test.Framework.NUnit.TestExtensions;
using NUnit.Framework;

namespace DR.DataAccess.Test.Framework.NUnit
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class DataTestAttribute : TestAttribute
    {
        private bool _shouldLog = true;
        private StringWriter _stringWriter;

        public bool ShouldLog
        {
            get { return _shouldLog; }
            set { _shouldLog = value; }
        }

        public DataTestAttribute()
        {
            _stringWriter = new StringWriter();
        }
    }
}
