
using System;
using System.Collections.Generic;
using DR.DataAccess.Linq2Sql.Strategies;

namespace DR.DataAccess.Linq2Sql
{
    public static class TestProviderFactory
    {
        public static T Create<T>(List<IContextBehavior> behaviors) where T : BaseTestProvider
        {
            var context = new NorthwindDataContext();
            behaviors.Do(b => b.ForEach(context.AddBehavior));
            return (T)Activator.CreateInstance(typeof(T), context);
        }
    }
}
