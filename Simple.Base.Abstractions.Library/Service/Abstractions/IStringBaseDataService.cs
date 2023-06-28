using Simple.Base.Contract.Abstractions;

namespace Simple.Base.Service.Abstractions;

public interface IStringBaseDataService<TContract> : IBaseDataService<string, TContract>
    where TContract : StringBaseContract
{

}