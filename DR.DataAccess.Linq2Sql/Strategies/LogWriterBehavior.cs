using System.Data.Linq;
using System.IO;

namespace DR.DataAccess.Linq2Sql.Strategies
{
    public class LogWriterBehavior : IContextBehavior
    {
        private StringWriter _swriter;

        public void Apply(DataContext context)
        {
            _swriter = new StringWriter();
            context.Log = _swriter;
        }

        public string Get
        {
            get
            {
                return _swriter.GetStringBuilder().ToString();
            }
        }

    }
}
