
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using DR.DataAccess.Linq2Sql;
using DR.DataAccess.Linq2Sql.Strategies;
using NUnit.Framework;

namespace DR.DataAccess.Test
{
    [Category("Queries")]
    [TestFixture(TypeArgs = new[] { typeof(EagerLoadBehavior) })]
    public class SimpleQueryTests : BaseQueryTest
    {
        private LinqToSqlTestProvider _provider;
        private List<IContextBehavior> _behaviors;

        public SimpleQueryTests() { }

        public SimpleQueryTests(Type beb)
        {
            //_behaviors = new List<IContextBehavior> { Activator.CreateInstance(beh) as IContextBehavior };
        }

        [TestFixtureSetUp]
        public void FixtureSetUp()
        {
            //TestContext -  have no access from Visual Studio
            _provider = TestProviderFactory.Create<LinqToSqlTestProvider>(new List<IContextBehavior>(_behaviors));
        }

        [Test]
        public void Test_Return_Orders()
        {
            _provider.GetOrders();
        }

        [TestCase(1, 1, 1, 2, 3, 1)]
        public void Test_Return_CustomerProducts(string productId)
        {
            _provider.GetCustomerProducts(productId);
        }

        [Test]
        [ExpectedException(typeof(SqlException))]
        public void Test_Return_SQlException()
        {
            Assert.IsTrue(true);
        }
    }

}
