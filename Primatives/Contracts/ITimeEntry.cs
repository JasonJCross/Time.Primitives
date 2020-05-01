using System;

namespace JJC.Time.Primitives
{
    public interface ITimeEntry
    {
        int TimeEntryId { get; }
        DateTime StartTime { get; }
        DateTime EndTime { get; }
        EntryType EntryType { get; }
        bool IsActive { get; }
        IUser User { get; }
    }
}
