using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DR.DataAccess.Test.Framework;

namespace DR.DataAccess.Test
{
    interface ILogQuery
    {
        void SetUpLog(ITestProvider provider);
        string GetLogQuery();
    }
}
