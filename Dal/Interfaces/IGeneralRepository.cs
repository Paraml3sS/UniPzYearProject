using System.Collections.Generic;

namespace Dal.Interfaces
{
    public interface IGeneralRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(string condition);
        TEntity Get(long id);
        TEntity Create(TEntity entity);
        TEntity Update(long id, TEntity entity);
        TEntity Delete(long id);
        IEnumerable<TEntity> Delete(string condition);
    }
}
