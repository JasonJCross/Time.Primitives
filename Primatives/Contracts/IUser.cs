using System;

namespace JJC.Time.Primitives
{
    public interface IUser
    {
        Guid UserId { get; }
        string Name { get; }
        IPerson Person { get; }
        string UserToken { get; }
        string Password { get; }
    }
}