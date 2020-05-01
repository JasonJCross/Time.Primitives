namespace JJC.Time.Primitives
{
    public interface ITimeEntryHistory
    {
        int TimeEntryHistoryId { get; }
        ITimeEntry TimeEntry { get; }
        IUser User { get; }
        ILocation Location { get; }
        HistoryType HistoryType { get; }
        string FieldName { get; }
        string FieldValue { get; }
    }
}
