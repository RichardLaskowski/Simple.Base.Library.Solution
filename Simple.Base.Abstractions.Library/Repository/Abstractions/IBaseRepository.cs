using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Simple.Base.Entity.Abstractions;

namespace Simple.Base.Repository.Abstractions;

public interface IBaseRepository<TType, TEntity>
    where TType : class
    where TEntity : BaseEntity<TType>
{
    #region Add

    TEntity Add(TEntity entity);
    IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities);

    #endregion Add

    #region Remove

    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);

    #endregion Remove

    #region Get

    TEntity Get(TType id);
    IEnumerable<TEntity> GetAll();

    #endregion Get

    #region Update

    void Update(TEntity entity);
    void UpdateRange(IEnumerable<TEntity> entities);

    #endregion

    #region Find

    IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);

    #endregion Find
}
