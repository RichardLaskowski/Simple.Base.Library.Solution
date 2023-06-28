using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Simple.Base.Entity.Abstractions;

namespace Simple.Base.Repository.Abstractions;
public interface IBaseAsyncRepository<TType, TEntity> : IBaseRepository<TType, TEntity>
    where TType : class
    where TEntity : BaseEntity<TType>
{
    #region Add

    Task<TEntity> AddAsync(TEntity entity);
    Task<IEnumerable<TEntity>> AddRangeAsync(IEnumerable<TEntity> entities);

    #endregion Add

    #region Remove

    Task RemoveAsync(TEntity entity);
    Task RemoveRangeAsync(IEnumerable<TEntity> entities);

    #endregion Remove

    #region Get

    Task<TEntity> GetAsync(TType id);
    Task<IEnumerable<TEntity>> GetAllAsync();

    #endregion Get

    #region Update

    Task UpdateAsync(TEntity enity);
    Task UpdateRangeAsync(IEnumerable<TEntity> entities);

    #endregion

    #region Find

    Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate);

    #endregion Find
}
