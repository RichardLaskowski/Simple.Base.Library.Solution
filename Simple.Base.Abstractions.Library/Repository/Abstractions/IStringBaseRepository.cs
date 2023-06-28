using Simple.Base.Entity.Abstractions;

namespace Simple.Base.Repository.Abstractions;
public interface IStringBaseRepository<TEntity> : IBaseRepository<string, TEntity>
    where TEntity : StringBaseEntity
{
}
