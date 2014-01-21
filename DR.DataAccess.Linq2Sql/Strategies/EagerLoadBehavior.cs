
using System.Data.Linq;

namespace DR.DataAccess.Linq2Sql.Strategies
{
    public class EagerLoadBehavior : IContextBehavior
    {
        public void Apply(DataContext context)
        {
            context.DeferredLoadingEnabled = false;
        }
    }
}
