using Simple.Base.Entity.Abstractions;

namespace Simple.Base.Repository.Abstractions;
public interface IInMemoryRepository<TType, TEntity> : IBaseRepository<TType, TEntity>
    where TType : class
    where TEntity : BaseEntity<TType>
{
    void Seed();
}
