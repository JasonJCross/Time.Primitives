using System;

namespace JJC.Time.Primitives
{
    public interface IPerson
    {
        Guid PersonId { get; }
        string Name { get; }
    }
}