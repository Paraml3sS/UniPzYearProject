using System.Configuration;
using System.Data.Common;
using Dal.Interfaces;

namespace Dal
{
    public class DbConnectionFactory : IConnectionFactory
    {
        private readonly DbProviderFactory _dbProviderFactory;
        private readonly string _dataProvider;
        private readonly string _connectionString;

        public DbConnectionFactory()
        {
            //var connectionCfg = ConfigurationManager.ConnectionStrings;

            //_dataProvider = connectionCfg[0].ProviderName;
            //_connectionString = connectionCfg[0].ConnectionString;
            //_dbProviderFactory = DbProviderFactories.GetFactory(_dataProvider);


            _dataProvider = ConfigurationManager.AppSettings["provider"];
            _connectionString = ConfigurationManager.ConnectionStrings["SqlProvider"].ConnectionString;
            _dbProviderFactory = DbProviderFactories.GetFactory(_dataProvider);
        }

        public DbConnection CreateConnection()
        {
            var connection = _dbProviderFactory.CreateConnection();
            
            //connection.ConnectionString = "Data Source=DESKTOP-22TA5GA\\YBSQL;Initial Catalog=UniPZLocalDB;Integrated Security=True";
            if (connection == null) { throw new ConfigurationErrorsException($"Failed to connect using data provider: {_dataProvider}"); }

            connection.ConnectionString = _connectionString;
            connection.Open();
            return connection;
        }
    }
}
