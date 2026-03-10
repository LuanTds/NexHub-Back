namespace User.Persistence.Models;

public class StoredEvent
{
    public Guid Id { get; set; }
    public Guid AggregateId { get; set; }
    public string AggregateType { get; set; }
    public int Version { get; set; }
    public string EventType { get; set; }
    public string Payload { get; set; }
    public DateTime OccurredOn { get; set; }
}