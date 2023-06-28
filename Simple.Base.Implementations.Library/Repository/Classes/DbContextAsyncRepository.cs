using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Simple.Base.Entity.Abstractions;
using Simple.Base.Repository.Abstractions;

namespace Simple.Base.Repository.Classes;

internal class DbContextAsyncRepository<TType, TEntity> : DbContextRepository<TType, TEntity>, IBaseAsyncRepository<TType, TEntity>
    where TType : class
    where TEntity : BaseEntity<TType>
{
    public DbContextAsyncRepository(DbContext context) : base(context)
    {
    }

    Task<TEntity> IBaseAsyncRepository<TType, TEntity>.AddAsync(TEntity entity) => throw new NotImplementedException();
    Task<IEnumerable<TEntity>> IBaseAsyncRepository<TType, TEntity>.AddRangeAsync(IEnumerable<TEntity> entities) => throw new NotImplementedException();
    Task IBaseAsyncRepository<TType, TEntity>.RemoveAsync(TEntity entity) => throw new NotImplementedException();
    Task IBaseAsyncRepository<TType, TEntity>.RemoveRangeAsync(IEnumerable<TEntity> entities) => throw new NotImplementedException();
    Task IBaseAsyncRepository<TType, TEntity>.UpdateAsync(TEntity enity) => throw new NotImplementedException();
    Task IBaseAsyncRepository<TType, TEntity>.UpdateRangeAsync(IEnumerable<TEntity> entities) => throw new NotImplementedException();
    public async Task<TEntity> GetAsync(TType id)
    {
        return await Context.Set<TEntity>().FindAsync(id)!;
    }
    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await Context.Set<TEntity>().ToListAsync()!;
    }

    public async Task<IEnumerable<TEntity>> FindAsync(Func<TEntity, bool> predicate)
    {
        return await Task.Run(() => Find(predicate));
    }
}
