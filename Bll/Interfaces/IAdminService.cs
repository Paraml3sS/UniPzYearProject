using System.Collections.Generic;

namespace Bll.Interfaces
{
    public interface IAdminService<TEntity>
    {
        IEnumerable<TEntity> Get();
        void Create(TEntity entity);
        void Update(long id, TEntity entity);
        void Delete(long id);

        void AddUserRole(long userId, long roleId);
        void DeleteUserRole(long userId, long roleId);
    }
}
