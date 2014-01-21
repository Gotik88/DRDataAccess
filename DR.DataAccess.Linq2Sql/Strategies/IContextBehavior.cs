using System.Data.Linq;

namespace DR.DataAccess.Linq2Sql.Strategies
{
    public interface IContextBehavior
    {
        void Apply(DataContext context);
    }
}
