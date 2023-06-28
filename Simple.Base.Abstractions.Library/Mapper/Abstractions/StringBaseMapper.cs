using Simple.Base.Contract.Abstractions;
using Simple.Base.Entity.Abstractions;

namespace Simple.Base.Mapper.Abstractions;

public abstract class StringBaseMapper<TEntity, TContract> : BaseMapper<string, TEntity, TContract>
    where TEntity : StringBaseEntity
    where TContract : StringBaseContract
{
}
