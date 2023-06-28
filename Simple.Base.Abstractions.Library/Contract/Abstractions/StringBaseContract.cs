using System;

namespace Simple.Base.Contract.Abstractions;

public abstract record StringBaseContract(string Id) : BaseContract<string>(!string.IsNullOrEmpty(Id) ? Id : Guid.NewGuid().ToString());
