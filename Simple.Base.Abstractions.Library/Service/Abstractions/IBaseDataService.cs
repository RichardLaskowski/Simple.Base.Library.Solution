using System.Collections.Generic;
using System.Threading.Tasks;

using Simple.Base.Contract.Abstractions;

namespace Simple.Base.Service.Abstractions;

public interface IBaseDataService<TType, TContract>
    where TType : class
    where TContract : BaseContract<TType>
{
    Task<TType> CreateAsync(TContract contract);
    Task DeleteAsync(TType id);
    Task UpdateAsync(TType id, TContract contract);
    Task<TContract> GetAsync(TType id);
    Task<IEnumerable<TContract>> GetAllAsync();
}