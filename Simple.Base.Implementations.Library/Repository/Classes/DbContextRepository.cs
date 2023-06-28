using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using Simple.Base.Entity.Abstractions;
using Simple.Base.Repository.Abstractions;

namespace Simple.Base.Repository.Classes;
internal class DbContextRepository<TType, TEntity> : IBaseRepository<TType, TEntity> 
    where TType : class
    where TEntity : BaseEntity<TType>
{
    protected readonly DbContext Context;

    public DbContextRepository(DbContext context)
    {
        Context = context;
    }

    public TEntity Add(TEntity entity)
    {
        Context.Add(entity);
        return entity;
    }
    public IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities)
    {
        Context.AddRange(entities);
        return entities;
    }

    public void Remove(TEntity entity)
    {
        Context.Remove(entity);
    }
    public void RemoveRange(IEnumerable<TEntity> entities)
    {
        Context.RemoveRange(entities);
    }

    public TEntity Get(TType id)
    {
        return Context.Set<TEntity>().Find(id)!;
    }
    public IEnumerable<TEntity> GetAll()
    {
        return Context.Set<TEntity>().ToList()!;
    }


    public void Update(TEntity entity)
    {
        Context.Update(entity);
    }
    public void UpdateRange(IEnumerable<TEntity> entities)
    {
        Context.UpdateRange(entities);
    }

    public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
    {
        return Context.Set<TEntity>().Where(predicate);
    }
}
