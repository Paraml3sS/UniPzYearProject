using System.Data.Common;

namespace Dal.Interfaces
{
    public interface IConnectionFactory
    {
        DbConnection CreateConnection();
    }
}
