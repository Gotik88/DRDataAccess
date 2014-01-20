using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using NUnit.Framework;

namespace DR.DataAccess.Test
{
    [TestFixture]
    public class SimpleQueryTests : SqlConnectionTestBase
    {
        private Stopwatch _watch;

        [TestFixtureSetUp]
        public void SetUp()
        {
            const string ConnectionStringName = "DomainServiceConnection";
            SetConnection(ConnectionStringName);
            _watch = new Stopwatch();
        }

        [Test, Owner(Owner.DmytroRomanii)]
        public void Test_Return_SimpleQuery()
        {
            _watch.Start();
            Assert.IsTrue(true);
            _watch.Stop();
            var time = _watch.Elapsed;
        }

        [Test]
        [ExpectedException(typeof(SqlException))]
        public void Test_Return_SQlException()
        {
            Assert.IsTrue(true);
        }
    }

}
