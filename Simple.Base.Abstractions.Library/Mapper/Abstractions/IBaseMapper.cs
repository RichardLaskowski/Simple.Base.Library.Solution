using System.Collections.Generic;
using System.Threading.Tasks;

using Simple.Base.Contract.Abstractions;
using Simple.Base.Entity.Abstractions;

namespace Simple.Base.Mapper.Abstractions;

public interface IBaseMapper<TType, TEntity, TContract>
    where TType : class
    where TEntity : BaseEntity<TType>
    where TContract : BaseContract<TType>
{
    TEntity Map(TContract contract);
    TContract Map(TEntity entity);

    IEnumerable<TEntity> MapAll(IEnumerable<TContract> contracts);
    IEnumerable<TContract> MapAll(IEnumerable<TEntity> entities);

    Task<TEntity> MapAsync(TContract contract);
    Task<TContract> MapAsync(TEntity entities);

    Task<IEnumerable<TEntity>> MapAllAsync(IEnumerable<TContract> contracts);
    Task<IEnumerable<TContract>> MapAllAsync(IEnumerable<TEntity> entities);
}
