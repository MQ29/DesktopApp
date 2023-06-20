using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logindb.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        public RepositoryBase()
        {
            _connectionString = "Data Source=DESKTOP-MHJGK2O;Initial Catalog=LoginDb;Integrated Security=True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
