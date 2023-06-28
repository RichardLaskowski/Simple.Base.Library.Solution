using Simple.Base.Contract.Abstractions;
using Simple.Base.Entity.Abstractions;

namespace Simple.Base.Mapper.Abstractions;
public interface IStringBaseMapper<TEntity, TContract> : IBaseMapper<string, TEntity, TContract>
    where TEntity : StringBaseEntity
    where TContract : StringBaseContract
{
}
