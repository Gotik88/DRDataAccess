using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR.DataAccess.Test
{
    public class SqlConnectionTestBase : IDisposable
    {
        private readonly ConnectionState[] _liveConnectionStates = new[]
        {
            ConnectionState.Connecting, 
            ConnectionState.Executing,
            ConnectionState.Fetching,
            ConnectionState.Open
        };

        protected SqlConnection Connection { get; set; }

        protected void SetConnection(string connectionStringName)
        {
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString);
            Connection.Open();
        }

        void IDisposable.Dispose()
        {
            if (_liveConnectionStates.Contains(Connection.State))
            {
                Connection.Close();
            }
        }
    }
}
