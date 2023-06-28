namespace Simple.Base.Contract.Abstractions;

public abstract record BaseContract<TType>(TType Id) where TType : class { }
