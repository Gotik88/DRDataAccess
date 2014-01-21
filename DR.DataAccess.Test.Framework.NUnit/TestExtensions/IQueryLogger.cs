using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DR.DataAccess.Test.Framework.NUnit.TestExtensions
{
    interface IQueryLogger
    {
        bool ShouldLog { get; set; }
    }
}
