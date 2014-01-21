
using System.Collections.Generic;
using DR.DataAccess.Linq2Sql.Strategies;

namespace DR.DataAccess.Linq2Sql
{
    public partial class NorthwindDataContext
    {
        protected List<IContextBehavior> Behaviors = new List<IContextBehavior>();
        public void AddBehavior(IContextBehavior behavior)
        {
            Behaviors.Add(behavior);
        }
    }
}
