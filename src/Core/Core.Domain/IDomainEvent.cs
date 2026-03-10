namespace Core.Domain;

public interface IDomainEvent
{
    Guid Id { get; }
    DateTime OccurredOn { get; }
    string EventType { get; }
}