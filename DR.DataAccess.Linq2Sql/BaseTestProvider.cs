using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR.DataAccess.Linq2Sql
{
    public abstract class BaseTestProvider
    {
        private readonly DataContext _context;

        public DataContext Context
        {
            get
            {
                return _context;
            }
        }

        protected BaseTestProvider(DataContext context)
        {
            _context = context;
        }
    }
}
