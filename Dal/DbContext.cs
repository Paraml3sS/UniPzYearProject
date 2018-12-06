using System;
using System.Data;
using Dal.Interfaces;

namespace Dal
{
    public class DbContext : IDisposable
    {
        private readonly IDbConnection _connection;
        private readonly IConnectionFactory _connectionFactory;

        public DbContext(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
            _connection = _connectionFactory.CreateConnection();
        }

        public IDbCommand CreateCommand()
        {
            return _connection.CreateCommand();
        }

        public void Dispose()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
                _connection.Close();
        }
    }
}
