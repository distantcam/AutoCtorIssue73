using A;
using AutoCtor;

namespace B;

public abstract class BaseClass<T, U, V>
{
    private readonly Interface<T, U> _interface;
    public BaseClass(Interface<T, U> i) => _interface = i;
}

[AutoConstruct]
public sealed partial class Class : BaseClass<object, int, string>
{
}